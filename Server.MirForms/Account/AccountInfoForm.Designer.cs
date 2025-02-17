﻿
namespace Server
{
    partial class AccountInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateButton = new Button();
            label1 = new Label();
            FilterTextBox = new TextBox();
            RefreshButton = new Button();
            AccountInfoPanel = new Panel();
            Delaccbtn = new Button();
            CharactersListView = new ListView();
            characterName = new ColumnHeader();
            characterClass = new ColumnHeader();
            characterLevel = new ColumnHeader();
            characterPKPoints = new ColumnHeader();
            characterGuild = new ColumnHeader();
            characterStatus = new ColumnHeader();
            LastIPSearch = new Button();
            CreationIPSearch = new Button();
            PasswordChangeCheckBox = new CheckBox();
            setPasswordButton = new Button();
            AdminCheckBox = new CheckBox();
            PermBanButton = new Button();
            WeekBanButton = new Button();
            DayBanButton = new Button();
            BannedCheckBox = new CheckBox();
            ExpiryDateTextBox = new TextBox();
            label14 = new Label();
            BanReasonTextBox = new TextBox();
            label13 = new Label();
            LastDateTextBox = new TextBox();
            label11 = new Label();
            LastIPTextBox = new TextBox();
            label12 = new Label();
            CreationDateTextBox = new TextBox();
            label9 = new Label();
            CreationIPTextBox = new TextBox();
            label10 = new Label();
            EMailTextBox = new TextBox();
            label8 = new Label();
            AnswerTextBox = new TextBox();
            label7 = new Label();
            QuestionTextBox = new TextBox();
            label6 = new Label();
            BirthDateTextBox = new TextBox();
            label5 = new Label();
            UserNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            AccountIDTextBox = new TextBox();
            label2 = new Label();
            label15 = new Label();
            FilterPlayerTextBox = new TextBox();
            AccountInfoListView = new CustomFormControl.ListViewNF();
            indexHeader = new ColumnHeader();
            accountIDHeader = new ColumnHeader();
            userNameHeader = new ColumnHeader();
            adminHeader = new ColumnHeader();
            bannedHeader = new ColumnHeader();
            banReasonHeader = new ColumnHeader();
            expiryDateHeader = new ColumnHeader();
            Gold = new ColumnHeader();
            GameGold = new ColumnHeader();
            MatchFilterCheckBox = new CheckBox();
            WipeCharButton = new Button();
            ServerGoldTextBox = new TextBox();
            TotalServerGold = new Label();
            ServerCreditTextBox = new TextBox();
            TotalServerCredit = new Label();
            FilterIPTextBox = new TextBox();
            label16 = new Label();
            AccountInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(14, 16);
            CreateButton.Margin = new Padding(4, 3, 4, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(88, 31);
            CreateButton.TabIndex = 9;
            CreateButton.Text = "创建账户";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 11;
            label1.Text = "匹配账户 ID:";
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(125, 51);
            FilterTextBox.Margin = new Padding(4, 3, 4, 3);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(116, 23);
            FilterTextBox.TabIndex = 12;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(678, 51);
            RefreshButton.Margin = new Padding(4, 3, 4, 3);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(88, 31);
            RefreshButton.TabIndex = 13;
            RefreshButton.Text = "刷新";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // AccountInfoPanel
            // 
            AccountInfoPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AccountInfoPanel.Controls.Add(Delaccbtn);
            AccountInfoPanel.Controls.Add(CharactersListView);
            AccountInfoPanel.Controls.Add(LastIPSearch);
            AccountInfoPanel.Controls.Add(CreationIPSearch);
            AccountInfoPanel.Controls.Add(PasswordChangeCheckBox);
            AccountInfoPanel.Controls.Add(setPasswordButton);
            AccountInfoPanel.Controls.Add(AdminCheckBox);
            AccountInfoPanel.Controls.Add(PermBanButton);
            AccountInfoPanel.Controls.Add(WeekBanButton);
            AccountInfoPanel.Controls.Add(DayBanButton);
            AccountInfoPanel.Controls.Add(BannedCheckBox);
            AccountInfoPanel.Controls.Add(ExpiryDateTextBox);
            AccountInfoPanel.Controls.Add(label14);
            AccountInfoPanel.Controls.Add(BanReasonTextBox);
            AccountInfoPanel.Controls.Add(label13);
            AccountInfoPanel.Controls.Add(LastDateTextBox);
            AccountInfoPanel.Controls.Add(label11);
            AccountInfoPanel.Controls.Add(LastIPTextBox);
            AccountInfoPanel.Controls.Add(label12);
            AccountInfoPanel.Controls.Add(CreationDateTextBox);
            AccountInfoPanel.Controls.Add(label9);
            AccountInfoPanel.Controls.Add(CreationIPTextBox);
            AccountInfoPanel.Controls.Add(label10);
            AccountInfoPanel.Controls.Add(EMailTextBox);
            AccountInfoPanel.Controls.Add(label8);
            AccountInfoPanel.Controls.Add(AnswerTextBox);
            AccountInfoPanel.Controls.Add(label7);
            AccountInfoPanel.Controls.Add(QuestionTextBox);
            AccountInfoPanel.Controls.Add(label6);
            AccountInfoPanel.Controls.Add(BirthDateTextBox);
            AccountInfoPanel.Controls.Add(label5);
            AccountInfoPanel.Controls.Add(UserNameTextBox);
            AccountInfoPanel.Controls.Add(label4);
            AccountInfoPanel.Controls.Add(label3);
            AccountInfoPanel.Controls.Add(AccountIDTextBox);
            AccountInfoPanel.Controls.Add(label2);
            AccountInfoPanel.Location = new Point(14, 314);
            AccountInfoPanel.Margin = new Padding(4, 3, 4, 3);
            AccountInfoPanel.Name = "AccountInfoPanel";
            AccountInfoPanel.Size = new Size(1248, 275);
            AccountInfoPanel.TabIndex = 14;
            // 
            // Delaccbtn
            // 
            Delaccbtn.Location = new Point(694, 235);
            Delaccbtn.Margin = new Padding(4, 3, 4, 3);
            Delaccbtn.Name = "Delaccbtn";
            Delaccbtn.Size = new Size(88, 31);
            Delaccbtn.TabIndex = 40;
            Delaccbtn.Text = "删除账户";
            Delaccbtn.UseVisualStyleBackColor = true;
            Delaccbtn.Click += Delaccbtn_Click;
            // 
            // CharactersListView
            // 
            CharactersListView.Columns.AddRange(new ColumnHeader[] { characterName, characterClass, characterLevel, characterPKPoints, characterGuild, characterStatus });
            CharactersListView.GridLines = true;
            CharactersListView.Location = new Point(701, 0);
            CharactersListView.Name = "CharactersListView";
            CharactersListView.Scrollable = false;
            CharactersListView.Size = new Size(546, 184);
            CharactersListView.TabIndex = 39;
            CharactersListView.UseCompatibleStateImageBehavior = false;
            CharactersListView.View = View.Details;
            // 
            // characterName
            // 
            characterName.Text = "名称";
            characterName.Width = 80;
            // 
            // characterClass
            // 
            characterClass.Text = "职业";
            characterClass.Width = 80;
            // 
            // characterLevel
            // 
            characterLevel.Text = "等级";
            // 
            // characterPKPoints
            // 
            characterPKPoints.Text = "PK点数";
            characterPKPoints.Width = 59;
            // 
            // characterGuild
            // 
            characterGuild.Text = "所属公会";
            characterGuild.Width = 100;
            // 
            // characterStatus
            // 
            characterStatus.Text = "账户角色状态";
            characterStatus.Width = 163;
            // 
            // LastIPSearch
            // 
            LastIPSearch.Location = new Point(583, 92);
            LastIPSearch.Name = "LastIPSearch";
            LastIPSearch.Size = new Size(25, 26);
            LastIPSearch.TabIndex = 38;
            LastIPSearch.Text = "🔎";
            LastIPSearch.UseVisualStyleBackColor = true;
            LastIPSearch.Click += LastIPSearch_Click;
            // 
            // CreationIPSearch
            // 
            CreationIPSearch.Location = new Point(583, 24);
            CreationIPSearch.Name = "CreationIPSearch";
            CreationIPSearch.Size = new Size(25, 26);
            CreationIPSearch.TabIndex = 37;
            CreationIPSearch.Text = "🔎";
            CreationIPSearch.UseVisualStyleBackColor = true;
            CreationIPSearch.Click += CreationIPSearch_Click;
            // 
            // PasswordChangeCheckBox
            // 
            PasswordChangeCheckBox.AutoSize = true;
            PasswordChangeCheckBox.Location = new Point(216, 57);
            PasswordChangeCheckBox.Margin = new Padding(4, 3, 4, 3);
            PasswordChangeCheckBox.Name = "PasswordChangeCheckBox";
            PasswordChangeCheckBox.Size = new Size(99, 21);
            PasswordChangeCheckBox.TabIndex = 34;
            PasswordChangeCheckBox.Text = "首次登录变更";
            PasswordChangeCheckBox.UseVisualStyleBackColor = true;
            PasswordChangeCheckBox.CheckedChanged += PasswordChangeCheckBox_CheckedChanged;
            // 
            // setPasswordButton
            // 
            setPasswordButton.Location = new Point(111, 53);
            setPasswordButton.Margin = new Padding(4, 3, 4, 3);
            setPasswordButton.Name = "setPasswordButton";
            setPasswordButton.Size = new Size(98, 31);
            setPasswordButton.TabIndex = 33;
            setPasswordButton.Text = "设置密码";
            setPasswordButton.UseVisualStyleBackColor = true;
            setPasswordButton.Click += button1_Click;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Location = new Point(241, 23);
            AdminCheckBox.Margin = new Padding(4, 3, 4, 3);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(87, 21);
            AdminCheckBox.TabIndex = 32;
            AdminCheckBox.Text = "管理员模式";
            AdminCheckBox.UseVisualStyleBackColor = true;
            AdminCheckBox.CheckedChanged += AdminCheckBox_CheckedChanged;
            // 
            // PermBanButton
            // 
            PermBanButton.Location = new Point(598, 235);
            PermBanButton.Margin = new Padding(4, 3, 4, 3);
            PermBanButton.Name = "PermBanButton";
            PermBanButton.Size = new Size(88, 31);
            PermBanButton.TabIndex = 31;
            PermBanButton.Text = "禁用一月";
            PermBanButton.UseVisualStyleBackColor = true;
            PermBanButton.Click += PermBanButton_Click;
            // 
            // WeekBanButton
            // 
            WeekBanButton.Location = new Point(502, 235);
            WeekBanButton.Margin = new Padding(4, 3, 4, 3);
            WeekBanButton.Name = "WeekBanButton";
            WeekBanButton.Size = new Size(88, 31);
            WeekBanButton.TabIndex = 30;
            WeekBanButton.Text = "禁用一周";
            WeekBanButton.UseVisualStyleBackColor = true;
            WeekBanButton.Click += WeekBanButton_Click;
            // 
            // DayBanButton
            // 
            DayBanButton.Location = new Point(407, 235);
            DayBanButton.Margin = new Padding(4, 3, 4, 3);
            DayBanButton.Name = "DayBanButton";
            DayBanButton.Size = new Size(88, 31);
            DayBanButton.TabIndex = 29;
            DayBanButton.Text = "禁用一日";
            DayBanButton.UseVisualStyleBackColor = true;
            DayBanButton.Click += DayBanButton_Click;
            // 
            // BannedCheckBox
            // 
            BannedCheckBox.AutoSize = true;
            BannedCheckBox.Location = new Point(610, 204);
            BannedCheckBox.Margin = new Padding(4, 3, 4, 3);
            BannedCheckBox.Name = "BannedCheckBox";
            BannedCheckBox.Size = new Size(51, 21);
            BannedCheckBox.TabIndex = 28;
            BannedCheckBox.Text = "禁用";
            BannedCheckBox.UseVisualStyleBackColor = true;
            BannedCheckBox.CheckedChanged += BannedCheckBox_CheckedChanged;
            // 
            // ExpiryDateTextBox
            // 
            ExpiryDateTextBox.Location = new Point(460, 202);
            ExpiryDateTextBox.Margin = new Padding(4, 3, 4, 3);
            ExpiryDateTextBox.Name = "ExpiryDateTextBox";
            ExpiryDateTextBox.Size = new Size(139, 23);
            ExpiryDateTextBox.TabIndex = 27;
            ExpiryDateTextBox.TextChanged += ExpiryDateTextBox_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(378, 205);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(83, 17);
            label14.TabIndex = 26;
            label14.Text = "账户解封日期:";
            // 
            // BanReasonTextBox
            // 
            BanReasonTextBox.Location = new Point(460, 168);
            BanReasonTextBox.Margin = new Padding(4, 3, 4, 3);
            BanReasonTextBox.Name = "BanReasonTextBox";
            BanReasonTextBox.Size = new Size(223, 23);
            BanReasonTextBox.TabIndex = 25;
            BanReasonTextBox.TextChanged += BanReasonTextBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(372, 171);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(83, 17);
            label13.TabIndex = 24;
            label13.Text = "账户禁用事由:";
            // 
            // LastDateTextBox
            // 
            LastDateTextBox.Location = new Point(460, 125);
            LastDateTextBox.Margin = new Padding(4, 3, 4, 3);
            LastDateTextBox.Name = "LastDateTextBox";
            LastDateTextBox.ReadOnly = true;
            LastDateTextBox.Size = new Size(139, 23);
            LastDateTextBox.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(374, 128);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 17);
            label11.TabIndex = 22;
            label11.Text = "最后登录日期:";
            // 
            // LastIPTextBox
            // 
            LastIPTextBox.Location = new Point(460, 91);
            LastIPTextBox.Margin = new Padding(4, 3, 4, 3);
            LastIPTextBox.Name = "LastIPTextBox";
            LastIPTextBox.ReadOnly = true;
            LastIPTextBox.Size = new Size(116, 23);
            LastIPTextBox.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(382, 94);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(74, 17);
            label12.TabIndex = 20;
            label12.Text = "近期登录 IP:";
            // 
            // CreationDateTextBox
            // 
            CreationDateTextBox.Location = new Point(460, 57);
            CreationDateTextBox.Margin = new Padding(4, 3, 4, 3);
            CreationDateTextBox.Name = "CreationDateTextBox";
            CreationDateTextBox.ReadOnly = true;
            CreationDateTextBox.Size = new Size(139, 23);
            CreationDateTextBox.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(365, 60);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 17);
            label9.TabIndex = 18;
            label9.Text = "账户创建日期:";
            // 
            // CreationIPTextBox
            // 
            CreationIPTextBox.Location = new Point(460, 23);
            CreationIPTextBox.Margin = new Padding(4, 3, 4, 3);
            CreationIPTextBox.Name = "CreationIPTextBox";
            CreationIPTextBox.ReadOnly = true;
            CreationIPTextBox.Size = new Size(116, 23);
            CreationIPTextBox.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(380, 26);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(74, 17);
            label10.TabIndex = 16;
            label10.Text = "创建账户 IP:";
            // 
            // EMailTextBox
            // 
            EMailTextBox.Location = new Point(111, 236);
            EMailTextBox.Margin = new Padding(4, 3, 4, 3);
            EMailTextBox.Name = "EMailTextBox";
            EMailTextBox.Size = new Size(223, 23);
            EMailTextBox.TabIndex = 15;
            EMailTextBox.TextChanged += EMailTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 239);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 14;
            label8.Text = "EMail 地址:";
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(111, 202);
            AnswerTextBox.Margin = new Padding(4, 3, 4, 3);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(153, 23);
            AnswerTextBox.TabIndex = 13;
            AnswerTextBox.TextChanged += AnswerTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 205);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 12;
            label7.Text = "密码答案:";
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.Location = new Point(111, 168);
            QuestionTextBox.Margin = new Padding(4, 3, 4, 3);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(153, 23);
            QuestionTextBox.TabIndex = 11;
            QuestionTextBox.TextChanged += QuestionTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 171);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 10;
            label6.Text = "密码问题:";
            // 
            // BirthDateTextBox
            // 
            BirthDateTextBox.Location = new Point(111, 134);
            BirthDateTextBox.Margin = new Padding(4, 3, 4, 3);
            BirthDateTextBox.Name = "BirthDateTextBox";
            BirthDateTextBox.Size = new Size(84, 23);
            BirthDateTextBox.TabIndex = 9;
            BirthDateTextBox.TextChanged += BirthDateTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 137);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 8;
            label5.Text = "出生日期:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(111, 100);
            UserNameTextBox.Margin = new Padding(4, 3, 4, 3);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(116, 23);
            UserNameTextBox.TabIndex = 7;
            UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 103);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 6;
            label4.Text = "账户名称:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 4;
            label3.Text = "密码:";
            // 
            // AccountIDTextBox
            // 
            AccountIDTextBox.Location = new Point(111, 18);
            AccountIDTextBox.Margin = new Padding(4, 3, 4, 3);
            AccountIDTextBox.Name = "AccountIDTextBox";
            AccountIDTextBox.Size = new Size(116, 23);
            AccountIDTextBox.TabIndex = 3;
            AccountIDTextBox.TextChanged += AccountIDTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 2;
            label2.Text = "账户ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(250, 54);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(59, 17);
            label15.TabIndex = 15;
            label15.Text = "匹配玩家:";
            // 
            // FilterPlayerTextBox
            // 
            FilterPlayerTextBox.Location = new Point(331, 51);
            FilterPlayerTextBox.Margin = new Padding(4, 3, 4, 3);
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            FilterPlayerTextBox.Size = new Size(116, 23);
            FilterPlayerTextBox.TabIndex = 16;
            // 
            // AccountInfoListView
            // 
            AccountInfoListView.AllowColumnReorder = true;
            AccountInfoListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AccountInfoListView.Columns.AddRange(new ColumnHeader[] { indexHeader, accountIDHeader, userNameHeader, adminHeader, bannedHeader, banReasonHeader, expiryDateHeader, Gold, GameGold });
            AccountInfoListView.FullRowSelect = true;
            AccountInfoListView.GridLines = true;
            AccountInfoListView.Location = new Point(12, 85);
            AccountInfoListView.Margin = new Padding(4, 3, 4, 3);
            AccountInfoListView.Name = "AccountInfoListView";
            AccountInfoListView.Size = new Size(1249, 219);
            AccountInfoListView.Sorting = SortOrder.Ascending;
            AccountInfoListView.TabIndex = 8;
            AccountInfoListView.UseCompatibleStateImageBehavior = false;
            AccountInfoListView.View = View.Details;
            AccountInfoListView.SelectedIndexChanged += AccountInfoListView_SelectedIndexChanged;
            // 
            // indexHeader
            // 
            indexHeader.Text = "序号";
            // 
            // accountIDHeader
            // 
            accountIDHeader.Text = "账户 ID";
            accountIDHeader.Width = 92;
            // 
            // userNameHeader
            // 
            userNameHeader.Text = "账户名称";
            userNameHeader.Width = 75;
            // 
            // adminHeader
            // 
            adminHeader.Text = "管理员";
            adminHeader.Width = 73;
            // 
            // bannedHeader
            // 
            bannedHeader.Text = "禁用";
            bannedHeader.Width = 54;
            // 
            // banReasonHeader
            // 
            banReasonHeader.Text = "禁用原因";
            banReasonHeader.Width = 74;
            // 
            // expiryDateHeader
            // 
            expiryDateHeader.Text = "封禁日期";
            expiryDateHeader.Width = 81;
            // 
            // Gold
            // 
            Gold.Text = "金币";
            Gold.Width = 100;
            // 
            // GameGold
            // 
            GameGold.Text = "元宝";
            GameGold.Width = 70;
            // 
            // MatchFilterCheckBox
            // 
            MatchFilterCheckBox.AutoSize = true;
            MatchFilterCheckBox.Location = new Point(774, 57);
            MatchFilterCheckBox.Margin = new Padding(4, 3, 4, 3);
            MatchFilterCheckBox.Name = "MatchFilterCheckBox";
            MatchFilterCheckBox.Size = new Size(75, 21);
            MatchFilterCheckBox.TabIndex = 17;
            MatchFilterCheckBox.Text = "匹配筛选";
            MatchFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // WipeCharButton
            // 
            WipeCharButton.Location = new Point(108, 16);
            WipeCharButton.Margin = new Padding(4, 3, 4, 3);
            WipeCharButton.Name = "WipeCharButton";
            WipeCharButton.Size = new Size(134, 31);
            WipeCharButton.TabIndex = 18;
            WipeCharButton.Text = "删除所有账户";
            WipeCharButton.UseVisualStyleBackColor = true;
            WipeCharButton.Click += WipeCharButton_Click;
            // 
            // ServerGoldTextBox
            // 
            ServerGoldTextBox.Location = new Point(356, 18);
            ServerGoldTextBox.Name = "ServerGoldTextBox";
            ServerGoldTextBox.ReadOnly = true;
            ServerGoldTextBox.Size = new Size(153, 23);
            ServerGoldTextBox.TabIndex = 22;
            // 
            // TotalServerGold
            // 
            TotalServerGold.AutoSize = true;
            TotalServerGold.Location = new Point(252, 22);
            TotalServerGold.Name = "TotalServerGold";
            TotalServerGold.Size = new Size(95, 17);
            TotalServerGold.TabIndex = 21;
            TotalServerGold.Text = "服务器金币总数:";
            // 
            // ServerCreditTextBox
            // 
            ServerCreditTextBox.Location = new Point(627, 22);
            ServerCreditTextBox.Name = "ServerCreditTextBox";
            ServerCreditTextBox.ReadOnly = true;
            ServerCreditTextBox.Size = new Size(153, 23);
            ServerCreditTextBox.TabIndex = 24;
            // 
            // TotalServerCredit
            // 
            TotalServerCredit.AutoSize = true;
            TotalServerCredit.Location = new Point(520, 25);
            TotalServerCredit.Name = "TotalServerCredit";
            TotalServerCredit.Size = new Size(107, 17);
            TotalServerCredit.TabIndex = 23;
            TotalServerCredit.Text = "服务器元宝总数:";
            // 
            // FilterIPTextBox
            // 
            FilterIPTextBox.Location = new Point(541, 51);
            FilterIPTextBox.Margin = new Padding(4, 3, 4, 3);
            FilterIPTextBox.Name = "FilterIPTextBox";
            FilterIPTextBox.Size = new Size(116, 23);
            FilterIPTextBox.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(460, 54);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(46, 17);
            label16.TabIndex = 25;
            label16.Text = "匹配IP:";
            // 
            // AccountInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 603);
            Controls.Add(FilterIPTextBox);
            Controls.Add(label16);
            Controls.Add(ServerCreditTextBox);
            Controls.Add(TotalServerCredit);
            Controls.Add(ServerGoldTextBox);
            Controls.Add(TotalServerGold);
            Controls.Add(WipeCharButton);
            Controls.Add(MatchFilterCheckBox);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(label15);
            Controls.Add(AccountInfoPanel);
            Controls.Add(RefreshButton);
            Controls.Add(FilterTextBox);
            Controls.Add(label1);
            Controls.Add(CreateButton);
            Controls.Add(AccountInfoListView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AccountInfoForm";
            Text = "账户信息窗口";
            FormClosed += AccountInfoForm_FormClosed;
            AccountInfoPanel.ResumeLayout(false);
            AccountInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private CustomFormControl.ListViewNF AccountInfoListView;
        private System.Windows.Forms.ColumnHeader indexHeader;
        private System.Windows.Forms.ColumnHeader accountIDHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.ColumnHeader userNameHeader;
        private System.Windows.Forms.ColumnHeader bannedHeader;
        private System.Windows.Forms.ColumnHeader banReasonHeader;
        private System.Windows.Forms.ColumnHeader expiryDateHeader;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel AccountInfoPanel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BirthDateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastDateTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LastIPTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CreationDateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CreationIPTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ExpiryDateTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BanReasonTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox BannedCheckBox;
        private System.Windows.Forms.Button PermBanButton;
        private System.Windows.Forms.Button WeekBanButton;
        private System.Windows.Forms.Button DayBanButton;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.ColumnHeader adminHeader;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox FilterPlayerTextBox;
        private System.Windows.Forms.CheckBox MatchFilterCheckBox;
        private System.Windows.Forms.Button WipeCharButton;
        private System.Windows.Forms.Button setPasswordButton;
        private System.Windows.Forms.CheckBox PasswordChangeCheckBox;
        private Button LastIPSearch;
        private Button CreationIPSearch;
        private ListView CharactersListView;
        private ColumnHeader characterName;
        private ColumnHeader characterClass;
        private ColumnHeader characterLevel;
        private ColumnHeader characterPKPoints;
        private ColumnHeader characterGuild;
        private ColumnHeader Gold;
        private ColumnHeader GameGold;
        private ColumnHeader characterStatus;
        private TextBox ServerGoldTextBox;
        private Label TotalServerGold;
        private TextBox ServerCreditTextBox;
        private Label TotalServerCredit;
        private Button Delaccbtn;
        private TextBox FilterIPTextBox;
        private Label label16;
    }
}