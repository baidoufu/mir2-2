﻿using Server.MirDatabase;
using Server.MirObjects;
using System.Diagnostics;

namespace Server
{
    public partial class PlayerInfoForm : Form
    {
        CharacterInfo Character = null;

        public PlayerInfoForm()
        {
            InitializeComponent();
        }

        public PlayerInfoForm(uint playerId)
        {
            InitializeComponent();

            PlayerObject player = SMain.Envir.GetPlayer(playerId);

            if (player == null)
            {
                Close();
                return;
            }

            Character = SMain.Envir.GetCharacterInfo(player.Name);

            UpdateTabs();
        }

        #region PlayerInfo
        private void UpdatePlayerInfo()
        {
            IndexTextBox.Text = Character.Index.ToString();
            NameTextBox.Text = Character.Name;
            LevelTextBox.Text = Character.Level.ToString();
            PKPointsTextBox.Text = Character.PKPoints.ToString();
            GoldTextBox.Text = $"{Character.AccountInfo.Gold:n0}";
            GameGoldTextBox.Text = String.Format("{0:n0}", Character.AccountInfo.Credit);


            if (Character?.Player != null)
            {
                CurrentMapLabel.Text = $"{Character.Player.CurrentMap.Info.Title} / {Character.Player.CurrentMap.Info.FileName}";
                CurrentXY.Text = $"X:{Character.CurrentLocation.X}: Y:{Character.CurrentLocation.Y}";

                ExpTextBox.Text = $"{string.Format("{0:#0.##%}", Character.Player.Experience / (double)Character.Player.MaxExperience)}";
                ACBox.Text = $"{Character.Player.Stats[Stat.MinAC]}-{Character.Player.Stats[Stat.MaxAC]}";
                AMCBox.Text = $"{Character.Player.Stats[Stat.MinMAC]}-{Character.Player.Stats[Stat.MaxMAC]}";
                DCBox.Text = $"{Character.Player.Stats[Stat.MinDC]}-{Character.Player.Stats[Stat.MaxDC]}";
                MCBox.Text = $"{Character.Player.Stats[Stat.MinMC]}-{Character.Player.Stats[Stat.MaxMC]}";
                SCBox.Text = $"{Character.Player.Stats[Stat.MinSC]}-{Character.Player.Stats[Stat.MaxSC]}";
                ACCBox.Text = $"{Character.Player.Stats[Stat.准确]}";
                AGILBox.Text = $"{Character.Player.Stats[Stat.敏捷]}";
                ATKSPDBox.Text = $"{Character.Player.Stats[Stat.攻击速度]}";
            }
            else
            {
                CurrentMapLabel.Text = "OFFLINE";
                CurrentXY.Text = "OFFLINE";
            }

            CurrentIPLabel.Text = Character.AccountInfo.LastIP;
            OnlineTimeLabel.Text = Character.LastLoginDate > Character.LastLogoutDate ? (SMain.Envir.Now - Character.LastLoginDate).TotalMinutes.ToString("##") + " 分钟" : "Offline";

            ChatBanExpiryTextBox.Text = Character.ChatBanExpiryDate.ToString();
        }
        #endregion

        #region PlayerPets
        private void UpdatePetInfo()
        {
            ClearPetInfo();

            if (Character?.Player == null) return;

            foreach (MonsterObject Pet in Character.Player.Pets)
            {
                var listItem = new ListViewItem(Pet.Name) { Tag = Pet };
                listItem.SubItems.Add(Pet.PetLevel.ToString());
                listItem.SubItems.Add($"{Pet.Health}/{Pet.MaxHealth}");
                listItem.SubItems.Add($"地图: {Pet.CurrentMap.Info.Title}, X: {Pet.CurrentLocation.X}, Y: {Pet.CurrentLocation.Y}");

                PetView.Items.Add(listItem);
            }
        }

        private void ClearPetInfo()
        {
            PetView.Items.Clear();
        }
        #endregion

        #region PlayerMagics
        private void UpdatePlayerMagics()
        {
            MagicListViewNF.Items.Clear();

            for (int i = 0; i < Character.Magics.Count; i++)
            {
                UserMagic magic = Character.Magics[i];
                if (magic == null) continue;

                ListViewItem ListItem = new ListViewItem(magic.Info.Name.ToString()) { Tag = this };

                ListItem.SubItems.Add(magic.Level.ToString());

                switch (magic.Level)
                {
                    case 0:
                        ListItem.SubItems.Add($"{magic.Experience}/{magic.Info.Need1}");
                        break;
                    case 1:
                        ListItem.SubItems.Add($"{magic.Experience}/{magic.Info.Need2}");
                        break;
                    case 2:
                        ListItem.SubItems.Add($"{magic.Experience}/{magic.Info.Need3}");
                        break;
                    case 3:
                        ListItem.SubItems.Add($"-");
                        break;
                }

                if (magic.Key > 8)
                {
                    var key = magic.Key % 8;

                    ListItem.SubItems.Add(string.Format("CTRL+F{0}", key != 0 ? key : 8));
                }
                else if (magic.Key > 0)
                {
                    ListItem.SubItems.Add(string.Format("F{0}", magic.Key));
                }
                else if (magic.Key == 0)
                {
                    ListItem.SubItems.Add(string.Format("未设置", magic.Key));
                }

                ListItem.SubItems.Add(magic.Key.ToString());
                MagicListViewNF.Items.Add(ListItem);
            }
        }
        #endregion

        #region PlayerQuests
        private void UpdatePlayerQuests()
        {
            QuestInfoListViewNF.Items.Clear();

            foreach (int completedQuestID in Character.CompletedQuests)
            {
                QuestInfo completedQuest = SMain.Envir.GetQuestInfo(completedQuestID);

                ListViewItem item = new ListViewItem(completedQuestID.ToString());
                item.SubItems.Add("已完成");
                item.SubItems.Add(completedQuest.Name.ToString());
                QuestInfoListViewNF.Items.Add(item);
            }

            foreach (QuestProgressInfo currentQuest in Character.CurrentQuests)
            {
                ListViewItem item = new ListViewItem(currentQuest.Index.ToString());
                item.SubItems.Add("进行中");
                item.SubItems.Add(currentQuest.Info.Name.ToString());
                QuestInfoListViewNF.Items.Add(item);
            }
        }
        #endregion

        #region PlayerItems
        private void UpdatePlayerItems()
        {
            PlayerItemInfoListViewNF.Items.Clear();

            if (Character == null) return;

            for (int i = 0; i < Character.Inventory.Length; i++)
            {
                UserItem inventoryItem = Character.Inventory[i];

                if (inventoryItem == null) continue;

                ListViewItem inventoryItemListItem = new ListViewItem($"{inventoryItem.UniqueID}");

                if (i < 6)
                {
                    inventoryItemListItem.SubItems.Add($"物品栏 | 位置: [{i + 1}]");
                }
                else if (i >= 6 && i < 46)
                {
                    inventoryItemListItem.SubItems.Add($"背包 | 位置: [{i - 5}]");
                }
                else
                {
                    inventoryItemListItem.SubItems.Add($"扩展背包 | 位置: [{i - 45}]");
                }

                inventoryItemListItem.SubItems.Add($"{inventoryItem.FriendlyName}");
                inventoryItemListItem.SubItems.Add($"{inventoryItem.Count}/{inventoryItem.Info.StackSize}");
                inventoryItemListItem.SubItems.Add($"{inventoryItem.CurrentDura}/{inventoryItem.MaxDura}");

                PlayerItemInfoListViewNF.Items.Add(inventoryItemListItem);
            }


            for (int i = 0; i < Character.QuestInventory.Length; i++)
            {
                UserItem questItem = Character.QuestInventory[i];

                if (questItem == null) continue;

                ListViewItem questItemListItem = new ListViewItem($"{questItem.UniqueID}");
                questItemListItem.SubItems.Add($"任务物品 | 位置: [{i + 1}]");

                questItemListItem.SubItems.Add($"{questItem.FriendlyName}");
                questItemListItem.SubItems.Add($"{questItem.Count}/{questItem.Info.StackSize}");
                questItemListItem.SubItems.Add($"{questItem.CurrentDura}/{questItem.MaxDura}");

                PlayerItemInfoListViewNF.Items.Add(questItemListItem);
            }

            for (int i = 0; i < Character.AccountInfo.Storage.Length; i++)
            {
                UserItem storeItem = Character.AccountInfo.Storage[i];

                if (storeItem == null) continue;

                ListViewItem storeItemListItem = new ListViewItem($"{storeItem.UniqueID}");

                if (i < 80)
                {
                    storeItemListItem.SubItems.Add($"仓库 | 位置: [{i + 1}]");
                }
                else
                {
                    storeItemListItem.SubItems.Add($"扩展仓库 | 位置: [{i - 79}]");
                }

                storeItemListItem.SubItems.Add($"{storeItem.FriendlyName}");
                storeItemListItem.SubItems.Add($"{storeItem.Count}/{storeItem.Info.StackSize}");
                storeItemListItem.SubItems.Add($"{storeItem.CurrentDura}/{storeItem.MaxDura}");

                PlayerItemInfoListViewNF.Items.Add(storeItemListItem);
            }

            for (int i = 0; i < Character.Equipment.Length; i++)
            {
                UserItem equipItem = Character.Equipment[i];

                if (equipItem == null) continue;

                ListViewItem equipItemListItem = new ListViewItem($"{equipItem.UniqueID}");

                equipItemListItem.SubItems.Add($"装备栏 | 位置: [{i + 1}]");

                equipItemListItem.SubItems.Add($"{equipItem.FriendlyName}");
                equipItemListItem.SubItems.Add($"{equipItem.Count}/{equipItem.Info.StackSize}");
                equipItemListItem.SubItems.Add($"{equipItem.CurrentDura}/{equipItem.MaxDura}");

                PlayerItemInfoListViewNF.Items.Add(equipItemListItem);
            }
        }
        #endregion

        #region Namelists
        private void UpdateNamelists()
        {
            // Define the directory path for the Namelists folder
            string namelistsPath = Path.Combine("Envir", "Namelists");

            // Ensure the directory exists
            if (!Directory.Exists(namelistsPath))
            {
                NamelistView.Items.Clear();
                NamelistView.Items.Add("未找到 Namelists 目录");
                return;
            }

            // Get the player's name from NameTextBox
            string playerName = NameTextBox.Text;

            // Clear the NamelistView before updating
            NamelistView.Items.Clear();

            // Track whether any matching files are found
            bool filesFound = false;

            // Iterate over each text file in the directory and subdirectories
            foreach (string filePath in Directory.GetFiles(namelistsPath, "*.txt", SearchOption.AllDirectories))
            {
                // Read all lines from the current file
                string[] lines = File.ReadAllLines(filePath);

                // Check if any line contains the player's name
                if (lines.Any(line => line.Contains(playerName)))
                {
                    // Get the relative path from the Namelists directory
                    string relativePath = Path.GetRelativePath(namelistsPath, filePath);

                    // Remove the .txt extension
                    relativePath = Path.ChangeExtension(relativePath, null);

                    // Add the relative path to the NamelistView
                    NamelistView.Items.Add(relativePath);
                    filesFound = true;
                }
            }

            // If no files contain the player's name, add a message to the NamelistView
            if (!filesFound)
            {
                NamelistView.Items.Add("尚未匹配到含有该玩家的名字的文件");
            }
        }
        private void NamelistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteNamelistButton.Enabled = NamelistView.SelectedItems.Count > 0;
        }
        private void DeleteNamelistButton_Click(object sender, EventArgs e)
        {
            if (NamelistView.SelectedItems.Count == 0)
                return;

            // Get the selected namelist file path (assuming one file can be selected at a time)
            string selectedFile = NamelistView.SelectedItems[0].Text;

            // Combine the selected item with the Namelists path
            string namelistsPath = Path.Combine("Envir", "Namelists");
            string fullPath = Path.Combine(namelistsPath, selectedFile + ".txt");

            // Show a confirmation message box
            DialogResult result = MessageBox.Show($"确定要从 '{selectedFile}' 中删除该玩家吗?",
                                                  "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Get the player's name from NameTextBox
                string playerName = NameTextBox.Text;

                // Read all lines, then rewrite the file without the player's name
                var lines = File.ReadAllLines(fullPath).Where(line => !line.Contains(playerName)).ToArray();
                File.WriteAllLines(fullPath, lines);

                // Optionally, update the NamelistView after deletion
                UpdateNamelists();
            }
        }
        private void Viewnamelistbutton_Click(object sender, EventArgs e)
        {
            if (NamelistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一个 名字列表 文件后进行查看");
                return;
            }

            // Get the selected namelist file path
            string selectedFile = NamelistView.SelectedItems[0].Text;
            string namelistsPath = Path.Combine("Envir", "Namelists");
            string fullPath = Path.Combine(namelistsPath, selectedFile + ".txt");

            // Check if the file exists
            if (File.Exists(fullPath))
            {
                // Use ProcessStartInfo to specify the file to open and its associated program
                var processInfo = new ProcessStartInfo
                {
                    FileName = fullPath,   // The file to open
                    UseShellExecute = true // This tells the system to use the default program associated with the file type
                };
                Process.Start(processInfo);
            }
            else
            {
                MessageBox.Show("未找到选中的 名字列表 文件");
            }
        }
        #endregion

        #region Buttons
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定要更新", "更新", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            SaveChanges();
        }

        private void SaveChanges()
        {
            CharacterInfo info = Character;

            string tempGold = GoldTextBox.Text.Replace(",", "");
            string tempCredit = GameGoldTextBox.Text.Replace(",", "");

            info.Name = NameTextBox.Text;
            info.Level = Convert.ToByte(LevelTextBox.Text);
            info.PKPoints = Convert.ToInt32(PKPointsTextBox.Text);
            info.AccountInfo.Gold = Convert.ToUInt32(tempGold);
            info.AccountInfo.Credit = Convert.ToUInt32(tempCredit);

            UpdateTabs();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (Character?.Player == null) return;

            if (SendMessageTextBox.Text.Length < 1) return;

            Character.Player.ReceiveChat(SendMessageTextBox.Text, ChatType.Announcement);
        }

        private void KickButton_Click(object sender, EventArgs e)
        {
            if (Character?.Player == null) return;

            Character.Player.Connection.SendDisconnect(4);
            //also update account so player can't log back in for x minutes?
        }

        private void KillButton_Click(object sender, EventArgs e)
        {
            if (Character?.Player == null) return;

            Character.Player.Die();
        }

        private void KillPetsButton_Click(object sender, EventArgs e)
        {
            if (Character?.Player == null) return;

            for (int i = Character.Player.Pets.Count - 1; i >= 0; i--)
                Character.Player.Pets[i].Die();

            ClearPetInfo();
        }
        private void SafeZoneButton_Click(object sender, EventArgs e)
        {
            if (Character?.Player == null) return;

            Character.Player.Teleport(SMain.Envir.GetMap(Character.BindMapIndex), Character.BindLocation);
        }

        private void ChatBanButton_Click(object sender, EventArgs e)
        {
            if (Character?.Player == null) return;
            if (Character.AccountInfo.AdminAccount) return;

            Character.ChatBanned = true;

            DateTime date;

            DateTime.TryParse(ChatBanExpiryTextBox.Text, out date);

            Character.ChatBanExpiryDate = date;
        }

        private void ChatBanExpiryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            DateTime temp;

            if (!DateTime.TryParse(ActiveControl.Text, out temp))
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;
        }

        private void OpenAccountButton_Click(object sender, EventArgs e)
        {
            string accountId = Character.AccountInfo.AccountID;

            AccountInfoForm form = new AccountInfoForm(accountId, true);

            form.ShowDialog();
        }

        private void CurrentIPLabel_Click(object sender, EventArgs e)
        {
            string ipAddress = CurrentIPLabel.Text;

            string url = $"https://127.0.0.1/ip/{ipAddress}";//默认 whatismyipaddress.com

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url)
                {
                    UseShellExecute = true
                });

                CurrentIPLabel.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开统一资源定位符时出错: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccountBanButton_Click(object sender, EventArgs e)
        {
            if (Character.AccountInfo.AdminAccount) return;

            Character.AccountInfo.Banned = true;

            DateTime date;

            DateTime.TryParse(ChatBanExpiryTextBox.Text, out date);

            Character.AccountInfo.ExpiryDate = date;

            if (Character?.Player != null)
            {
                Character.Player.Connection.SendDisconnect(6);
            }
        }
        #endregion

        #region PlayerFlagSearch
        private void FlagSearchBox_ValueChanged_1(object sender, EventArgs e)
        {
            int flagIndex = 0;
            if (string.IsNullOrWhiteSpace(FlagSearchBox.Value.ToString()))
            {
                ResultLabel.Text = string.Empty;
                return;
            }
            else
            {
                flagIndex = Decimal.ToInt32(FlagSearchBox.Value);
            }

            if (flagIndex >= 0 && flagIndex < Character.Flags.Length)
            {
                bool flagValue = Character.Flags[flagIndex];

                if (flagValue)
                {
                    ResultLabel.Text = $"标志 {flagIndex} 是激活状态";
                    ResultLabel.ForeColor = Color.Green;
                }
                else
                {
                    ResultLabel.Text = $"标志 {flagIndex} 是未激活状态";
                    ResultLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                ResultLabel.Text = "无效的标志编号";
                ResultLabel.ForeColor = Color.Red;
            }
        }
        #endregion

        #region UpdateTabs
        private void UpdateTabs()
        {
            UpdatePlayerInfo();
            UpdatePetInfo();
            UpdatePlayerItems();
            UpdatePlayerMagics();
            UpdatePlayerQuests();
            UpdateHeroList();
            UpdateNamelists();
        }
        #endregion

        #region Tab Resize
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Size = new Size(725, 510);
                    break;
                case 1:
                    Size = new Size(423, 510);
                    break;
                case 2:
                    Size = new Size(597, 510);
                    break;
                case 3:
                    Size = new Size(458, 510);
                    break;
                case 4:
                    Size = new Size(663, 510);
                    break;
                case 5:
                    Size = new Size(403, 510);
                    break;
            }

            UpdateTabs();
        }
        #endregion

        #region Hero List
        private void UpdateHeroList()
        {
            ClearHeroList();

            if (Character == null || Character.Heroes == null) return;

            foreach (HeroInfo hero in Character.Heroes)
            {
                if (hero == null) continue;

                var listItem = new ListViewItem(hero.Name ?? "Unknown") { Tag = hero };
                listItem.SubItems.Add(hero.Level.ToString());
                listItem.SubItems.Add(hero.Class.ToString());
                listItem.SubItems.Add(hero.Gender.ToString());

                HeroListView.Items.Add(listItem);
            }
        }
        private void ClearHeroList()
        {
            HeroListView.Items.Clear();
        }
        #endregion
    }
}