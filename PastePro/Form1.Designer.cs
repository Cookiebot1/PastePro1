namespace PastePro
{
    partial class PastePro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastePro));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PasteStringToFirst = new System.Windows.Forms.CheckBox();
            this.TrimCopiedText = new System.Windows.Forms.CheckBox();
            this.RunOnWindowsStart = new System.Windows.Forms.CheckBox();
            this.FirstString = new System.Windows.Forms.TextBox();
            this.SecondString = new System.Windows.Forms.TextBox();
            this.ThirdString = new System.Windows.Forms.TextBox();
            this.FourthString = new System.Windows.Forms.TextBox();
            this.FourthEnabled = new System.Windows.Forms.CheckBox();
            this.FourthShortcut = new System.Windows.Forms.TextBox();
            this.ThirdEnabled = new System.Windows.Forms.CheckBox();
            this.ThirdShortcut = new System.Windows.Forms.TextBox();
            this.SecondEnabled = new System.Windows.Forms.CheckBox();
            this.SecondShortcut = new System.Windows.Forms.TextBox();
            this.FirstEnabled = new System.Windows.Forms.CheckBox();
            this.FirstShortcut = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.EnabledLabel = new System.Windows.Forms.Label();
            this.CurrentStringLabel = new System.Windows.Forms.Label();
            this.ShortcutKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Click to edit shortcuts and text";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // PasteStringToFirst
            // 
            this.PasteStringToFirst.AutoSize = true;
            this.PasteStringToFirst.Checked = global::PastePro.Properties.Settings.Default.PasteToFirst;
            this.PasteStringToFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PasteStringToFirst.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PasteStringToFirst.Location = new System.Drawing.Point(15, 227);
            this.PasteStringToFirst.Name = "PasteStringToFirst";
            this.PasteStringToFirst.Size = new System.Drawing.Size(305, 17);
            this.PasteStringToFirst.TabIndex = 24;
            this.PasteStringToFirst.Text = "Paste string automatically to first stringholder on copy";
            this.toolTip.SetToolTip(this.PasteStringToFirst, "Paste text on copy to first shortcut area");
            this.PasteStringToFirst.UseVisualStyleBackColor = true;
            // 
            // TrimCopiedText
            // 
            this.TrimCopiedText.AutoSize = true;
            this.TrimCopiedText.Checked = global::PastePro.Properties.Settings.Default.TrimCopiedText;
            this.TrimCopiedText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrimCopiedText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TrimCopiedText.Location = new System.Drawing.Point(15, 204);
            this.TrimCopiedText.Name = "TrimCopiedText";
            this.TrimCopiedText.Size = new System.Drawing.Size(107, 17);
            this.TrimCopiedText.TabIndex = 1;
            this.TrimCopiedText.Text = "Trim copied text";
            this.toolTip.SetToolTip(this.TrimCopiedText, "Remove extra spaces from start and end of copied text");
            this.TrimCopiedText.UseVisualStyleBackColor = true;
            // 
            // RunOnWindowsStart
            // 
            this.RunOnWindowsStart.AutoSize = true;
            this.RunOnWindowsStart.Checked = global::PastePro.Properties.Settings.Default.WindowsStartup;
            this.RunOnWindowsStart.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RunOnWindowsStart.Location = new System.Drawing.Point(15, 181);
            this.RunOnWindowsStart.Name = "RunOnWindowsStart";
            this.RunOnWindowsStart.Size = new System.Drawing.Size(160, 17);
            this.RunOnWindowsStart.TabIndex = 0;
            this.RunOnWindowsStart.Text = "Run when windows starts";
            this.toolTip.SetToolTip(this.RunOnWindowsStart, "Run program on windows start");
            this.RunOnWindowsStart.UseVisualStyleBackColor = true;
            // 
            // FirstString
            // 
            this.FirstString.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FirstString.Location = new System.Drawing.Point(211, 33);
            this.FirstString.Name = "FirstString";
            this.FirstString.ShortcutsEnabled = false;
            this.FirstString.Size = new System.Drawing.Size(455, 22);
            this.FirstString.TabIndex = 11;
            this.FirstString.TabStop = false;
            this.toolTip.SetToolTip(this.FirstString, "Click to paste current clipboard");
            this.FirstString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StringBox_MouseClick);
            // 
            // SecondString
            // 
            this.SecondString.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SecondString.Location = new System.Drawing.Point(211, 61);
            this.SecondString.Name = "SecondString";
            this.SecondString.ShortcutsEnabled = false;
            this.SecondString.Size = new System.Drawing.Size(455, 22);
            this.SecondString.TabIndex = 15;
            this.SecondString.TabStop = false;
            this.toolTip.SetToolTip(this.SecondString, "Click to paste current clipboard");
            this.SecondString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StringBox_MouseClick);
            // 
            // ThirdString
            // 
            this.ThirdString.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ThirdString.Location = new System.Drawing.Point(211, 89);
            this.ThirdString.Name = "ThirdString";
            this.ThirdString.ShortcutsEnabled = false;
            this.ThirdString.Size = new System.Drawing.Size(455, 22);
            this.ThirdString.TabIndex = 19;
            this.ThirdString.TabStop = false;
            this.toolTip.SetToolTip(this.ThirdString, "Click to paste current clipboard");
            this.ThirdString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StringBox_MouseClick);
            // 
            // FourthString
            // 
            this.FourthString.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FourthString.Location = new System.Drawing.Point(211, 117);
            this.FourthString.Name = "FourthString";
            this.FourthString.ShortcutsEnabled = false;
            this.FourthString.Size = new System.Drawing.Size(455, 22);
            this.FourthString.TabIndex = 23;
            this.FourthString.TabStop = false;
            this.toolTip.SetToolTip(this.FourthString, "Click to paste current clipboard");
            this.FourthString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StringBox_MouseClick);
            // 
            // FourthEnabled
            // 
            this.FourthEnabled.AutoSize = true;
            this.FourthEnabled.Checked = global::PastePro.Properties.Settings.Default.FourthEnabled;
            this.FourthEnabled.Location = new System.Drawing.Point(27, 120);
            this.FourthEnabled.Name = "FourthEnabled";
            this.FourthEnabled.Size = new System.Drawing.Size(15, 14);
            this.FourthEnabled.TabIndex = 21;
            this.toolTip.SetToolTip(this.FourthEnabled, "Enable this slot");
            this.FourthEnabled.UseVisualStyleBackColor = true;
            this.FourthEnabled.CheckedChanged += new System.EventHandler(this.EnabledCheckedChange);
            // 
            // FourthShortcut
            // 
            this.FourthShortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FourthShortcut.Location = new System.Drawing.Point(69, 117);
            this.FourthShortcut.MaxLength = 24;
            this.FourthShortcut.Name = "FourthShortcut";
            this.FourthShortcut.Size = new System.Drawing.Size(136, 22);
            this.FourthShortcut.TabIndex = 20;
            this.FourthShortcut.Text = global::PastePro.Properties.Settings.Default.FourthShortcut;
            this.toolTip.SetToolTip(this.FourthShortcut, "Click to activate, then press keys to set hotkey");
            this.FourthShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyDown);
            this.FourthShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyUp);
            // 
            // ThirdEnabled
            // 
            this.ThirdEnabled.AutoSize = true;
            this.ThirdEnabled.Checked = global::PastePro.Properties.Settings.Default.ThirdEnabled;
            this.ThirdEnabled.Location = new System.Drawing.Point(27, 92);
            this.ThirdEnabled.Name = "ThirdEnabled";
            this.ThirdEnabled.Size = new System.Drawing.Size(15, 14);
            this.ThirdEnabled.TabIndex = 17;
            this.toolTip.SetToolTip(this.ThirdEnabled, "Enable this slot");
            this.ThirdEnabled.UseVisualStyleBackColor = true;
            this.ThirdEnabled.CheckedChanged += new System.EventHandler(this.EnabledCheckedChange);
            // 
            // ThirdShortcut
            // 
            this.ThirdShortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ThirdShortcut.Location = new System.Drawing.Point(69, 89);
            this.ThirdShortcut.MaxLength = 24;
            this.ThirdShortcut.Name = "ThirdShortcut";
            this.ThirdShortcut.Size = new System.Drawing.Size(136, 22);
            this.ThirdShortcut.TabIndex = 16;
            this.ThirdShortcut.Text = global::PastePro.Properties.Settings.Default.ThirdShortcut;
            this.toolTip.SetToolTip(this.ThirdShortcut, "Click to activate, then press keys to set hotkey");
            this.ThirdShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyDown);
            this.ThirdShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyUp);
            // 
            // SecondEnabled
            // 
            this.SecondEnabled.AutoSize = true;
            this.SecondEnabled.Checked = global::PastePro.Properties.Settings.Default.SecondEnabled;
            this.SecondEnabled.Location = new System.Drawing.Point(27, 64);
            this.SecondEnabled.Name = "SecondEnabled";
            this.SecondEnabled.Size = new System.Drawing.Size(15, 14);
            this.SecondEnabled.TabIndex = 13;
            this.toolTip.SetToolTip(this.SecondEnabled, "Enable this slot");
            this.SecondEnabled.UseVisualStyleBackColor = true;
            this.SecondEnabled.CheckedChanged += new System.EventHandler(this.EnabledCheckedChange);
            // 
            // SecondShortcut
            // 
            this.SecondShortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SecondShortcut.Location = new System.Drawing.Point(69, 61);
            this.SecondShortcut.MaxLength = 24;
            this.SecondShortcut.Name = "SecondShortcut";
            this.SecondShortcut.Size = new System.Drawing.Size(136, 22);
            this.SecondShortcut.TabIndex = 12;
            this.SecondShortcut.Text = global::PastePro.Properties.Settings.Default.SecondShortcut;
            this.toolTip.SetToolTip(this.SecondShortcut, "Click to activate, then press keys to set hotkey");
            this.SecondShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyDown);
            this.SecondShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyUp);
            // 
            // FirstEnabled
            // 
            this.FirstEnabled.AutoSize = true;
            this.FirstEnabled.Checked = global::PastePro.Properties.Settings.Default.FirstEnabled;
            this.FirstEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FirstEnabled.Location = new System.Drawing.Point(27, 36);
            this.FirstEnabled.Name = "FirstEnabled";
            this.FirstEnabled.Size = new System.Drawing.Size(15, 14);
            this.FirstEnabled.TabIndex = 9;
            this.toolTip.SetToolTip(this.FirstEnabled, "Enable this slot");
            this.FirstEnabled.UseVisualStyleBackColor = true;
            this.FirstEnabled.CheckedChanged += new System.EventHandler(this.EnabledCheckedChange);
            // 
            // FirstShortcut
            // 
            this.FirstShortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FirstShortcut.Location = new System.Drawing.Point(69, 33);
            this.FirstShortcut.MaxLength = 24;
            this.FirstShortcut.Name = "FirstShortcut";
            this.FirstShortcut.Size = new System.Drawing.Size(136, 22);
            this.FirstShortcut.TabIndex = 5;
            this.FirstShortcut.Text = global::PastePro.Properties.Settings.Default.FirstShortcut;
            this.toolTip.SetToolTip(this.FirstShortcut, "Click to activate, then press keys to set hotkey");
            this.FirstShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyDown);
            this.FirstShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCutBoxKeyUp);
            // 
            // Save
            // 
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(267, 177);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 23);
            this.Save.TabIndex = 26;
            this.Save.Text = "Save Settings";
            this.toolTip.SetToolTip(this.Save, "Save current settings");
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.OptionsLabel.Location = new System.Drawing.Point(12, 163);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(50, 15);
            this.OptionsLabel.TabIndex = 2;
            this.OptionsLabel.Text = "Options";
            // 
            // EnabledLabel
            // 
            this.EnabledLabel.AutoSize = true;
            this.EnabledLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabledLabel.ForeColor = System.Drawing.Color.White;
            this.EnabledLabel.Location = new System.Drawing.Point(8, 9);
            this.EnabledLabel.Name = "EnabledLabel";
            this.EnabledLabel.Size = new System.Drawing.Size(50, 15);
            this.EnabledLabel.TabIndex = 6;
            this.EnabledLabel.Text = "Enabled";
            // 
            // CurrentStringLabel
            // 
            this.CurrentStringLabel.AutoSize = true;
            this.CurrentStringLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStringLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentStringLabel.Location = new System.Drawing.Point(208, 9);
            this.CurrentStringLabel.Name = "CurrentStringLabel";
            this.CurrentStringLabel.Size = new System.Drawing.Size(257, 15);
            this.CurrentStringLabel.TabIndex = 8;
            this.CurrentStringLabel.Text = "Current string (click to get current clipboard)";
            // 
            // ShortcutKeyLabel
            // 
            this.ShortcutKeyLabel.AutoSize = true;
            this.ShortcutKeyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortcutKeyLabel.ForeColor = System.Drawing.Color.White;
            this.ShortcutKeyLabel.Location = new System.Drawing.Point(66, 9);
            this.ShortcutKeyLabel.Name = "ShortcutKeyLabel";
            this.ShortcutKeyLabel.Size = new System.Drawing.Size(79, 15);
            this.ShortcutKeyLabel.TabIndex = 25;
            this.ShortcutKeyLabel.Text = "Shortcut key";
            // 
            // PastePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(766, 249);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ShortcutKeyLabel);
            this.Controls.Add(this.PasteStringToFirst);
            this.Controls.Add(this.FourthString);
            this.Controls.Add(this.FourthEnabled);
            this.Controls.Add(this.FourthShortcut);
            this.Controls.Add(this.ThirdString);
            this.Controls.Add(this.ThirdEnabled);
            this.Controls.Add(this.ThirdShortcut);
            this.Controls.Add(this.SecondString);
            this.Controls.Add(this.SecondEnabled);
            this.Controls.Add(this.SecondShortcut);
            this.Controls.Add(this.FirstString);
            this.Controls.Add(this.FirstEnabled);
            this.Controls.Add(this.CurrentStringLabel);
            this.Controls.Add(this.EnabledLabel);
            this.Controls.Add(this.FirstShortcut);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.TrimCopiedText);
            this.Controls.Add(this.RunOnWindowsStart);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PastePro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SavoniusSoft Paste Pro";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox RunOnWindowsStart;
        private System.Windows.Forms.CheckBox TrimCopiedText;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.TextBox FirstShortcut;
        private System.Windows.Forms.Label EnabledLabel;
        private System.Windows.Forms.Label CurrentStringLabel;
        private System.Windows.Forms.CheckBox FirstEnabled;
        private System.Windows.Forms.TextBox FirstString;
        private System.Windows.Forms.TextBox SecondString;
        private System.Windows.Forms.CheckBox SecondEnabled;
        private System.Windows.Forms.TextBox SecondShortcut;
        private System.Windows.Forms.TextBox ThirdString;
        private System.Windows.Forms.CheckBox ThirdEnabled;
        private System.Windows.Forms.TextBox ThirdShortcut;
        private System.Windows.Forms.TextBox FourthString;
        private System.Windows.Forms.CheckBox FourthEnabled;
        private System.Windows.Forms.TextBox FourthShortcut;
        private System.Windows.Forms.CheckBox PasteStringToFirst;
        private System.Windows.Forms.Label ShortcutKeyLabel;
        private System.Windows.Forms.Button Save;
    }
}

