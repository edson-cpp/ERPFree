namespace ERPFree
{
    partial class frmClients
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
            tsClients = new ToolStrip();
            btnNew = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnFind = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFirst = new ToolStripButton();
            btnPrior = new ToolStripButton();
            btnNext = new ToolStripButton();
            btnLast = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnExit = new ToolStripButton();
            tbcClients = new TabControl();
            tabIdentification = new TabPage();
            txtBirthDate = new MaskedTextBox();
            txtMothersName = new TextBox();
            txtWebsite = new TextBox();
            txtCorporateName = new TextBox();
            txtStateRegistration = new TextBox();
            txtFathersName = new TextBox();
            txtNationality = new TextBox();
            txtNaturalness = new TextBox();
            txtFantasyName = new TextBox();
            txtEIN = new MaskedTextBox();
            txtRegistrationDate = new MaskedTextBox();
            cbbGender = new ComboBox();
            cbbStatus = new ComboBox();
            cbbMaritalStatus = new ComboBox();
            cbbType = new ComboBox();
            labGender = new Label();
            labBirthDate = new Label();
            labRegistrationDate = new Label();
            labStateRegistration = new Label();
            labStatus = new Label();
            labWebsite = new Label();
            labMothersName = new Label();
            labFathersName = new Label();
            labMaritalStatus = new Label();
            labNationality = new Label();
            labNaturalness = new Label();
            labEIN = new Label();
            labFantasyName = new Label();
            labCorporateName = new Label();
            labType = new Label();
            tabAddresses = new TabPage();
            grdAddress = new DataGridView();
            colMain = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colNumber = new DataGridViewTextBoxColumn();
            colComplement = new DataGridViewTextBoxColumn();
            colReferencePoint = new DataGridViewTextBoxColumn();
            colCity = new DataGridViewTextBoxColumn();
            colState = new DataGridViewTextBoxColumn();
            colDistrict = new DataGridViewTextBoxColumn();
            colZipcode = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            btnMainAddress = new Button();
            btnDeleteAddress = new Button();
            btnChangeAddress = new Button();
            btnInsertAddress = new Button();
            tabContact = new TabPage();
            comboBox5 = new ComboBox();
            textBox24 = new TextBox();
            textBox23 = new TextBox();
            textBox22 = new TextBox();
            textBox21 = new TextBox();
            textBox20 = new TextBox();
            textBox19 = new TextBox();
            textBox18 = new TextBox();
            textBox17 = new TextBox();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            labPhone = new Label();
            labRole = new Label();
            labName = new Label();
            tabBilling = new TabPage();
            tabCredit = new TabPage();
            tabInvoicing = new TabPage();
            tabObservation = new TabPage();
            tsClients.SuspendLayout();
            tbcClients.SuspendLayout();
            tabIdentification.SuspendLayout();
            tabAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAddress).BeginInit();
            tabContact.SuspendLayout();
            SuspendLayout();
            // 
            // tsClients
            // 
            tsClients.BackColor = SystemColors.Control;
            tsClients.ImageScalingSize = new Size(32, 32);
            tsClients.Items.AddRange(new ToolStripItem[] { btnNew, btnEdit, btnFind, btnDelete, toolStripSeparator1, btnFirst, btnPrior, btnNext, btnLast, toolStripSeparator2, btnExit });
            tsClients.Location = new Point(0, 0);
            tsClients.Name = "tsClients";
            tsClients.Size = new Size(800, 39);
            tsClients.TabIndex = 0;
            tsClients.ItemClicked += tsClients_ItemClicked;
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNew.Image = Properties.Resources._new;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(36, 36);
            btnNew.Text = "toolStripButton1";
            btnNew.ToolTipText = "Novo";
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 36);
            btnEdit.Text = "toolStripButton2";
            btnEdit.ToolTipText = "Editar";
            // 
            // btnFind
            // 
            btnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFind.Image = Properties.Resources.find;
            btnFind.ImageTransparentColor = Color.Magenta;
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(36, 36);
            btnFind.Text = "toolStripButton3";
            btnFind.ToolTipText = "Localizar";
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 36);
            btnDelete.Text = "toolStripButton4";
            btnDelete.ToolTipText = "Excluir";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btnFirst
            // 
            btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFirst.Image = Properties.Resources.first;
            btnFirst.ImageTransparentColor = Color.Magenta;
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 36);
            btnFirst.Text = "toolStripButton5";
            btnFirst.ToolTipText = "Primeiro";
            // 
            // btnPrior
            // 
            btnPrior.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPrior.Image = Properties.Resources.left;
            btnPrior.ImageTransparentColor = Color.Magenta;
            btnPrior.Name = "btnPrior";
            btnPrior.Size = new Size(36, 36);
            btnPrior.Text = "toolStripButton6";
            btnPrior.ToolTipText = "Anterior";
            // 
            // btnNext
            // 
            btnNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNext.Image = Properties.Resources.right;
            btnNext.ImageTransparentColor = Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 36);
            btnNext.Text = "toolStripButton7";
            btnNext.ToolTipText = "Próximo";
            // 
            // btnLast
            // 
            btnLast.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLast.Image = Properties.Resources.last;
            btnLast.ImageTransparentColor = Color.Magenta;
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 36);
            btnLast.Text = "toolStripButton8";
            btnLast.ToolTipText = "Último";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = Properties.Resources.exit;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(36, 36);
            btnExit.Text = "toolStripButton9";
            btnExit.ToolTipText = "Sair";
            // 
            // tbcClients
            // 
            tbcClients.Controls.Add(tabIdentification);
            tbcClients.Controls.Add(tabAddresses);
            tbcClients.Controls.Add(tabContact);
            tbcClients.Controls.Add(tabBilling);
            tbcClients.Controls.Add(tabCredit);
            tbcClients.Controls.Add(tabInvoicing);
            tbcClients.Controls.Add(tabObservation);
            tbcClients.Location = new Point(12, 42);
            tbcClients.Name = "tbcClients";
            tbcClients.SelectedIndex = 0;
            tbcClients.Size = new Size(776, 396);
            tbcClients.TabIndex = 1;
            // 
            // tabIdentification
            // 
            tabIdentification.Controls.Add(txtBirthDate);
            tabIdentification.Controls.Add(txtMothersName);
            tabIdentification.Controls.Add(txtWebsite);
            tabIdentification.Controls.Add(txtCorporateName);
            tabIdentification.Controls.Add(txtStateRegistration);
            tabIdentification.Controls.Add(txtFathersName);
            tabIdentification.Controls.Add(txtNationality);
            tabIdentification.Controls.Add(txtNaturalness);
            tabIdentification.Controls.Add(txtFantasyName);
            tabIdentification.Controls.Add(txtEIN);
            tabIdentification.Controls.Add(txtRegistrationDate);
            tabIdentification.Controls.Add(cbbGender);
            tabIdentification.Controls.Add(cbbStatus);
            tabIdentification.Controls.Add(cbbMaritalStatus);
            tabIdentification.Controls.Add(cbbType);
            tabIdentification.Controls.Add(labGender);
            tabIdentification.Controls.Add(labBirthDate);
            tabIdentification.Controls.Add(labRegistrationDate);
            tabIdentification.Controls.Add(labStateRegistration);
            tabIdentification.Controls.Add(labStatus);
            tabIdentification.Controls.Add(labWebsite);
            tabIdentification.Controls.Add(labMothersName);
            tabIdentification.Controls.Add(labFathersName);
            tabIdentification.Controls.Add(labMaritalStatus);
            tabIdentification.Controls.Add(labNationality);
            tabIdentification.Controls.Add(labNaturalness);
            tabIdentification.Controls.Add(labEIN);
            tabIdentification.Controls.Add(labFantasyName);
            tabIdentification.Controls.Add(labCorporateName);
            tabIdentification.Controls.Add(labType);
            tabIdentification.Location = new Point(4, 24);
            tabIdentification.Name = "tabIdentification";
            tabIdentification.Padding = new Padding(3);
            tabIdentification.Size = new Size(768, 368);
            tabIdentification.TabIndex = 0;
            tabIdentification.Text = "Identificação";
            tabIdentification.UseVisualStyleBackColor = true;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(469, 171);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(121, 23);
            txtBirthDate.TabIndex = 30;
            // 
            // txtMothersName
            // 
            txtMothersName.Location = new Point(130, 259);
            txtMothersName.Name = "txtMothersName";
            txtMothersName.Size = new Size(460, 23);
            txtMothersName.TabIndex = 29;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(130, 288);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(460, 23);
            txtWebsite.TabIndex = 28;
            // 
            // txtCorporateName
            // 
            txtCorporateName.Location = new Point(130, 55);
            txtCorporateName.Name = "txtCorporateName";
            txtCorporateName.Size = new Size(460, 23);
            txtCorporateName.TabIndex = 26;
            // 
            // txtStateRegistration
            // 
            txtStateRegistration.Location = new Point(469, 113);
            txtStateRegistration.Name = "txtStateRegistration";
            txtStateRegistration.Size = new Size(121, 23);
            txtStateRegistration.TabIndex = 25;
            // 
            // txtFathersName
            // 
            txtFathersName.Location = new Point(130, 230);
            txtFathersName.Name = "txtFathersName";
            txtFathersName.Size = new Size(460, 23);
            txtFathersName.TabIndex = 24;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(130, 171);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(195, 23);
            txtNationality.TabIndex = 23;
            // 
            // txtNaturalness
            // 
            txtNaturalness.Location = new Point(130, 142);
            txtNaturalness.Name = "txtNaturalness";
            txtNaturalness.Size = new Size(195, 23);
            txtNaturalness.TabIndex = 22;
            // 
            // txtFantasyName
            // 
            txtFantasyName.Location = new Point(130, 84);
            txtFantasyName.Name = "txtFantasyName";
            txtFantasyName.Size = new Size(460, 23);
            txtFantasyName.TabIndex = 21;
            // 
            // txtEIN
            // 
            txtEIN.Location = new Point(130, 113);
            txtEIN.Name = "txtEIN";
            txtEIN.Size = new Size(195, 23);
            txtEIN.TabIndex = 20;
            // 
            // txtRegistrationDate
            // 
            txtRegistrationDate.Location = new Point(469, 142);
            txtRegistrationDate.Name = "txtRegistrationDate";
            txtRegistrationDate.Size = new Size(121, 23);
            txtRegistrationDate.TabIndex = 19;
            // 
            // cbbGender
            // 
            cbbGender.FormattingEnabled = true;
            cbbGender.Location = new Point(469, 201);
            cbbGender.Name = "cbbGender";
            cbbGender.Size = new Size(121, 23);
            cbbGender.TabIndex = 18;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Location = new Point(331, 26);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(121, 23);
            cbbStatus.TabIndex = 17;
            // 
            // cbbMaritalStatus
            // 
            cbbMaritalStatus.FormattingEnabled = true;
            cbbMaritalStatus.Location = new Point(130, 201);
            cbbMaritalStatus.Name = "cbbMaritalStatus";
            cbbMaritalStatus.Size = new Size(121, 23);
            cbbMaritalStatus.TabIndex = 16;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Location = new Point(130, 26);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(121, 23);
            cbbType.TabIndex = 15;
            // 
            // labGender
            // 
            labGender.AutoSize = true;
            labGender.Location = new Point(423, 204);
            labGender.Name = "labGender";
            labGender.Size = new Size(35, 15);
            labGender.TabIndex = 14;
            labGender.Text = "Sexo:";
            // 
            // labBirthDate
            // 
            labBirthDate.AutoSize = true;
            labBirthDate.Location = new Point(341, 174);
            labBirthDate.Name = "labBirthDate";
            labBirthDate.Size = new Size(117, 15);
            labBirthDate.TabIndex = 13;
            labBirthDate.Text = "Data de Nascimento:";
            // 
            // labRegistrationDate
            // 
            labRegistrationDate.AutoSize = true;
            labRegistrationDate.Location = new Point(358, 145);
            labRegistrationDate.Name = "labRegistrationDate";
            labRegistrationDate.Size = new Size(100, 15);
            labRegistrationDate.TabIndex = 12;
            labRegistrationDate.Text = "Data de Cadastro:";
            // 
            // labStateRegistration
            // 
            labStateRegistration.AutoSize = true;
            labStateRegistration.Location = new Point(354, 116);
            labStateRegistration.Name = "labStateRegistration";
            labStateRegistration.Size = new Size(104, 15);
            labStateRegistration.TabIndex = 11;
            labStateRegistration.Text = "Inscrição Estadual:";
            // 
            // labStatus
            // 
            labStatus.AutoSize = true;
            labStatus.Location = new Point(270, 29);
            labStatus.Name = "labStatus";
            labStatus.Size = new Size(55, 15);
            labStatus.TabIndex = 10;
            labStatus.Text = "Situação:";
            // 
            // labWebsite
            // 
            labWebsite.AutoSize = true;
            labWebsite.Location = new Point(27, 291);
            labWebsite.Name = "labWebsite";
            labWebsite.Size = new Size(52, 15);
            labWebsite.TabIndex = 9;
            labWebsite.Text = "Website:";
            // 
            // labMothersName
            // 
            labMothersName.AutoSize = true;
            labMothersName.Location = new Point(27, 262);
            labMothersName.Name = "labMothersName";
            labMothersName.Size = new Size(85, 15);
            labMothersName.TabIndex = 8;
            labMothersName.Text = "Nome da Mãe:";
            // 
            // labFathersName
            // 
            labFathersName.AutoSize = true;
            labFathersName.Location = new Point(27, 233);
            labFathersName.Name = "labFathersName";
            labFathersName.Size = new Size(79, 15);
            labFathersName.TabIndex = 7;
            labFathersName.Text = "Nome do Pai:";
            // 
            // labMaritalStatus
            // 
            labMaritalStatus.AutoSize = true;
            labMaritalStatus.Location = new Point(27, 204);
            labMaritalStatus.Name = "labMaritalStatus";
            labMaritalStatus.Size = new Size(71, 15);
            labMaritalStatus.TabIndex = 6;
            labMaritalStatus.Text = "Estado Civil:";
            // 
            // labNationality
            // 
            labNationality.AutoSize = true;
            labNationality.Location = new Point(27, 174);
            labNationality.Name = "labNationality";
            labNationality.Size = new Size(86, 15);
            labNationality.TabIndex = 5;
            labNationality.Text = "Nacionalidade:";
            // 
            // labNaturalness
            // 
            labNaturalness.AutoSize = true;
            labNaturalness.Location = new Point(27, 145);
            labNaturalness.Name = "labNaturalness";
            labNaturalness.Size = new Size(78, 15);
            labNaturalness.TabIndex = 4;
            labNaturalness.Text = "Naturalidade:";
            // 
            // labEIN
            // 
            labEIN.AutoSize = true;
            labEIN.Location = new Point(27, 116);
            labEIN.Name = "labEIN";
            labEIN.Size = new Size(35, 15);
            labEIN.TabIndex = 3;
            labEIN.Text = "Cnpj:";
            // 
            // labFantasyName
            // 
            labFantasyName.AutoSize = true;
            labFantasyName.Location = new Point(27, 89);
            labFantasyName.Name = "labFantasyName";
            labFantasyName.Size = new Size(89, 15);
            labFantasyName.TabIndex = 2;
            labFantasyName.Text = "Nome Fantasia:";
            // 
            // labCorporateName
            // 
            labCorporateName.AutoSize = true;
            labCorporateName.Location = new Point(27, 58);
            labCorporateName.Name = "labCorporateName";
            labCorporateName.Size = new Size(75, 15);
            labCorporateName.TabIndex = 1;
            labCorporateName.Text = "Razão Social:";
            // 
            // labType
            // 
            labType.AutoSize = true;
            labType.Location = new Point(27, 29);
            labType.Name = "labType";
            labType.Size = new Size(33, 15);
            labType.TabIndex = 0;
            labType.Text = "Tipo:";
            // 
            // tabAddresses
            // 
            tabAddresses.Controls.Add(grdAddress);
            tabAddresses.Controls.Add(btnMainAddress);
            tabAddresses.Controls.Add(btnDeleteAddress);
            tabAddresses.Controls.Add(btnChangeAddress);
            tabAddresses.Controls.Add(btnInsertAddress);
            tabAddresses.Location = new Point(4, 24);
            tabAddresses.Name = "tabAddresses";
            tabAddresses.Padding = new Padding(3);
            tabAddresses.Size = new Size(768, 368);
            tabAddresses.TabIndex = 1;
            tabAddresses.Text = "Endereços";
            tabAddresses.UseVisualStyleBackColor = true;
            // 
            // grdAddress
            // 
            grdAddress.AllowUserToOrderColumns = true;
            grdAddress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAddress.Columns.AddRange(new DataGridViewColumn[] { colMain, colType, colAddress, colNumber, colComplement, colReferencePoint, colCity, colState, colDistrict, colZipcode, colContact, colPhone });
            grdAddress.Location = new Point(18, 52);
            grdAddress.Name = "grdAddress";
            grdAddress.RowTemplate.Height = 25;
            grdAddress.Size = new Size(732, 298);
            grdAddress.TabIndex = 4;
            // 
            // colMain
            // 
            colMain.HeaderText = "Pcpal";
            colMain.Name = "colMain";
            colMain.Width = 40;
            // 
            // colType
            // 
            colType.HeaderText = "Tipo";
            colType.Name = "colType";
            colType.Width = 60;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Endereço";
            colAddress.Name = "colAddress";
            colAddress.Width = 200;
            // 
            // colNumber
            // 
            colNumber.HeaderText = "Número";
            colNumber.Name = "colNumber";
            colNumber.Width = 60;
            // 
            // colComplement
            // 
            colComplement.HeaderText = "Complemento";
            colComplement.Name = "colComplement";
            // 
            // colReferencePoint
            // 
            colReferencePoint.HeaderText = "Ponto de Ref.";
            colReferencePoint.Name = "colReferencePoint";
            colReferencePoint.Width = 110;
            // 
            // colCity
            // 
            colCity.HeaderText = "Cidade";
            colCity.Name = "colCity";
            colCity.Width = 150;
            // 
            // colState
            // 
            colState.HeaderText = "UF";
            colState.Name = "colState";
            colState.Width = 30;
            // 
            // colDistrict
            // 
            colDistrict.HeaderText = "Bairro";
            colDistrict.Name = "colDistrict";
            colDistrict.Width = 110;
            // 
            // colZipcode
            // 
            colZipcode.HeaderText = "Cep";
            colZipcode.Name = "colZipcode";
            // 
            // colContact
            // 
            colContact.HeaderText = "Contato";
            colContact.Name = "colContact";
            colContact.Width = 120;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Telefone";
            colPhone.Name = "colPhone";
            // 
            // btnMainAddress
            // 
            btnMainAddress.Location = new Point(261, 23);
            btnMainAddress.Name = "btnMainAddress";
            btnMainAddress.Size = new Size(75, 23);
            btnMainAddress.TabIndex = 3;
            btnMainAddress.Text = "&Principal";
            btnMainAddress.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAddress
            // 
            btnDeleteAddress.Location = new Point(180, 23);
            btnDeleteAddress.Name = "btnDeleteAddress";
            btnDeleteAddress.Size = new Size(75, 23);
            btnDeleteAddress.TabIndex = 2;
            btnDeleteAddress.Text = "&Excluir";
            btnDeleteAddress.UseVisualStyleBackColor = true;
            // 
            // btnChangeAddress
            // 
            btnChangeAddress.Location = new Point(99, 23);
            btnChangeAddress.Name = "btnChangeAddress";
            btnChangeAddress.Size = new Size(75, 23);
            btnChangeAddress.TabIndex = 1;
            btnChangeAddress.Text = "&Alterar";
            btnChangeAddress.UseVisualStyleBackColor = true;
            // 
            // btnInsertAddress
            // 
            btnInsertAddress.Location = new Point(18, 23);
            btnInsertAddress.Name = "btnInsertAddress";
            btnInsertAddress.Size = new Size(75, 23);
            btnInsertAddress.TabIndex = 0;
            btnInsertAddress.Text = "&Inserir";
            btnInsertAddress.UseVisualStyleBackColor = true;
            // 
            // tabContact
            // 
            tabContact.Controls.Add(comboBox5);
            tabContact.Controls.Add(textBox24);
            tabContact.Controls.Add(textBox23);
            tabContact.Controls.Add(textBox22);
            tabContact.Controls.Add(textBox21);
            tabContact.Controls.Add(textBox20);
            tabContact.Controls.Add(textBox19);
            tabContact.Controls.Add(textBox18);
            tabContact.Controls.Add(textBox17);
            tabContact.Controls.Add(textBox16);
            tabContact.Controls.Add(textBox15);
            tabContact.Controls.Add(textBox14);
            tabContact.Controls.Add(textBox13);
            tabContact.Controls.Add(textBox12);
            tabContact.Controls.Add(textBox11);
            tabContact.Controls.Add(textBox10);
            tabContact.Controls.Add(label16);
            tabContact.Controls.Add(label15);
            tabContact.Controls.Add(label14);
            tabContact.Controls.Add(label13);
            tabContact.Controls.Add(label12);
            tabContact.Controls.Add(label11);
            tabContact.Controls.Add(label10);
            tabContact.Controls.Add(label9);
            tabContact.Controls.Add(label8);
            tabContact.Controls.Add(label7);
            tabContact.Controls.Add(label6);
            tabContact.Controls.Add(label5);
            tabContact.Controls.Add(label4);
            tabContact.Controls.Add(labPhone);
            tabContact.Controls.Add(labRole);
            tabContact.Controls.Add(labName);
            tabContact.Location = new Point(4, 24);
            tabContact.Name = "tabContact";
            tabContact.Padding = new Padding(3);
            tabContact.Size = new Size(768, 368);
            tabContact.TabIndex = 2;
            tabContact.Text = "Contato";
            tabContact.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(105, 137);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 31;
            // 
            // textBox24
            // 
            textBox24.Location = new Point(441, 223);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(100, 23);
            textBox24.TabIndex = 30;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(442, 192);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(100, 23);
            textBox23.TabIndex = 29;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(436, 161);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(100, 23);
            textBox22.TabIndex = 28;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(443, 130);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(100, 23);
            textBox21.TabIndex = 27;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(442, 96);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(100, 23);
            textBox20.TabIndex = 26;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(441, 69);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(100, 23);
            textBox19.TabIndex = 25;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(441, 30);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(100, 23);
            textBox18.TabIndex = 24;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(105, 274);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(100, 23);
            textBox17.TabIndex = 23;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(105, 245);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(100, 23);
            textBox16.TabIndex = 22;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(279, 189);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(100, 23);
            textBox15.TabIndex = 21;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(105, 166);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(100, 23);
            textBox14.TabIndex = 20;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(105, 108);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(100, 23);
            textBox13.TabIndex = 19;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(105, 79);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 18;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(105, 50);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 17;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(105, 21);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(629, 233);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 15;
            label16.Text = "label16";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(629, 207);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 14;
            label15.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(625, 181);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 13;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(623, 151);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 12;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(626, 128);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 11;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(624, 100);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 10;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(625, 77);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 9;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(619, 45);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 277);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 248);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 169);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 140);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 111);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // labPhone
            // 
            labPhone.AutoSize = true;
            labPhone.Location = new Point(25, 82);
            labPhone.Name = "labPhone";
            labPhone.Size = new Size(54, 15);
            labPhone.TabIndex = 2;
            labPhone.Text = "Telefone:";
            // 
            // labRole
            // 
            labRole.AutoSize = true;
            labRole.Location = new Point(25, 53);
            labRole.Name = "labRole";
            labRole.Size = new Size(42, 15);
            labRole.TabIndex = 1;
            labRole.Text = "Cargo:";
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Location = new Point(25, 24);
            labName.Name = "labName";
            labName.Size = new Size(43, 15);
            labName.TabIndex = 0;
            labName.Text = "Nome:";
            // 
            // tabBilling
            // 
            tabBilling.Location = new Point(4, 24);
            tabBilling.Name = "tabBilling";
            tabBilling.Padding = new Padding(3);
            tabBilling.Size = new Size(768, 368);
            tabBilling.TabIndex = 3;
            tabBilling.Text = "Cobrança";
            tabBilling.UseVisualStyleBackColor = true;
            // 
            // tabCredit
            // 
            tabCredit.Location = new Point(4, 24);
            tabCredit.Name = "tabCredit";
            tabCredit.Padding = new Padding(3);
            tabCredit.Size = new Size(768, 368);
            tabCredit.TabIndex = 4;
            tabCredit.Text = "Crédito";
            tabCredit.UseVisualStyleBackColor = true;
            // 
            // tabInvoicing
            // 
            tabInvoicing.Location = new Point(4, 24);
            tabInvoicing.Name = "tabInvoicing";
            tabInvoicing.Padding = new Padding(3);
            tabInvoicing.Size = new Size(768, 368);
            tabInvoicing.TabIndex = 5;
            tabInvoicing.Text = "Faturamento";
            tabInvoicing.UseVisualStyleBackColor = true;
            // 
            // tabObservation
            // 
            tabObservation.Location = new Point(4, 24);
            tabObservation.Name = "tabObservation";
            tabObservation.Padding = new Padding(3);
            tabObservation.Size = new Size(768, 368);
            tabObservation.TabIndex = 6;
            tabObservation.Text = "Observação";
            tabObservation.UseVisualStyleBackColor = true;
            // 
            // frmClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcClients);
            Controls.Add(tsClients);
            Name = "frmClients";
            Text = "Cadastro de Clientes";
            Load += frmClients_Load;
            tsClients.ResumeLayout(false);
            tsClients.PerformLayout();
            tbcClients.ResumeLayout(false);
            tabIdentification.ResumeLayout(false);
            tabIdentification.PerformLayout();
            tabAddresses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAddress).EndInit();
            tabContact.ResumeLayout(false);
            tabContact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsClients;
        private ToolStripButton btnNew;
        private ToolStripButton btnEdit;
        private ToolStripButton btnFind;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnFirst;
        private ToolStripButton btnPrior;
        private ToolStripButton btnNext;
        private ToolStripButton btnLast;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnExit;
        private TabControl tbcClients;
        private TabPage tabIdentification;
        private TextBox txtMothersName;
        private TextBox txtWebsite;
        private TextBox txtCorporateName;
        private TextBox txtStateRegistration;
        private TextBox txtFathersName;
        private TextBox txtNationality;
        private TextBox txtNaturalness;
        private TextBox txtFantasyName;
        private MaskedTextBox txtEIN;
        private MaskedTextBox txtRegistrationDate;
        private ComboBox cbbGender;
        private ComboBox cbbStatus;
        private ComboBox cbbMaritalStatus;
        private ComboBox cbbType;
        private Label labGender;
        private Label labBirthDate;
        private Label labRegistrationDate;
        private Label labStateRegistration;
        private Label labStatus;
        private Label labWebsite;
        private Label labMothersName;
        private Label labFathersName;
        private Label labMaritalStatus;
        private Label labNationality;
        private Label labNaturalness;
        private Label labEIN;
        private Label labFantasyName;
        private Label labCorporateName;
        private Label labType;
        private TabPage tabAddresses;
        private TabPage tabContact;
        private TabPage tabBilling;
        private TabPage tabCredit;
        private TabPage tabInvoicing;
        private TabPage tabObservation;
        private DataGridView grdAddress;
        private Button btnMainAddress;
        private Button btnDeleteAddress;
        private Button btnChangeAddress;
        private Button btnInsertAddress;
        private DataGridViewTextBoxColumn colMain;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colComplement;
        private DataGridViewTextBoxColumn colReferencePoint;
        private DataGridViewTextBoxColumn colCity;
        private DataGridViewTextBoxColumn colState;
        private DataGridViewTextBoxColumn colDistrict;
        private DataGridViewTextBoxColumn colZipcode;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colPhone;
        private MaskedTextBox txtBirthDate;
        private ComboBox comboBox5;
        private TextBox textBox24;
        private TextBox textBox23;
        private TextBox textBox22;
        private TextBox textBox21;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label labPhone;
        private Label labRole;
        private Label labName;
    }
}