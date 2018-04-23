namespace SpellingFormShowingEvents
{
    partial class Form1
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary spellCheckerOpenOfficeDictionary1 = new DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(103, 12);
            this.memoEdit1.Name = "memoEdit1";
            this.spellChecker1.SetShowSpellCheckMenu(this.memoEdit1, true);
            this.memoEdit1.Size = new System.Drawing.Size(343, 375);
            this.spellChecker1.SetSpellCheckerOptions(this.memoEdit1, optionsSpelling1);
            this.memoEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Check Spelling";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spellChecker1
            // 
            this.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-US");
            spellCheckerOpenOfficeDictionary1.AlphabetPath = "EnglishAlphabet.txt";
            spellCheckerOpenOfficeDictionary1.CacheKey = null;
            spellCheckerOpenOfficeDictionary1.Culture = new System.Globalization.CultureInfo("en-US");
            spellCheckerOpenOfficeDictionary1.DictionaryPath = "en_US.dic";
            spellCheckerOpenOfficeDictionary1.Encoding = System.Text.Encoding.GetEncoding(1251);
            spellCheckerOpenOfficeDictionary1.GrammarPath = "en_US.aff";
            this.spellChecker1.Dictionaries.Add(spellCheckerOpenOfficeDictionary1);
            this.spellChecker1.ParentContainer = null;
            this.spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType;
            this.spellChecker1.SpellingFormShowing += new DevExpress.XtraSpellChecker.SpellingFormShowingEventHandler(this.spellChecker1_SpellingFormShowing);
            this.spellChecker1.OptionsFormShowing += new DevExpress.XtraSpellChecker.FormShowingEventHandler(this.spellChecker1_OptionsFormShowing);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 399);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.memoEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

