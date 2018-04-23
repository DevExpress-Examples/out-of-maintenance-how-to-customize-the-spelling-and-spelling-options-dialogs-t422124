using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingFormShowingEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            spellChecker1.Check(memoEdit1);
        }

        #region #SpellingFormShowingEvent
        private void spellChecker1_SpellingFormShowing(object sender, DevExpress.XtraSpellChecker.SpellingFormShowingEventArgs e)
        {
            var spellDialogForm = spellChecker1.FormsManager.SpellCheckForm;

            spellDialogForm.Controls["btnIgnore"].Enabled = false;
            spellDialogForm.Controls["btnIgnoreAll"].Visible = false;
            spellDialogForm.Controls["btnChangeAll"].Visible = false;
            spellDialogForm.Controls.Add(new SimpleButton() { Text = "Custom Button", Size = new Size(100, 25), Location = new Point(10, 150) });
        }
        #endregion #SpellingFormShowingEvent

        #region #OptionsFormShowingEvent
        private void spellChecker1_OptionsFormShowing(object sender, DevExpress.XtraSpellChecker.FormShowingEventArgs e)
        {
            var optionsForm = spellChecker1.FormsManager.OptionsForm;
            // You can hide the 'Add' button 
            spellChecker1.FormsManager.SpellCheckForm.Controls["btnAdd"].Visible = false;

            // Or suppress the entire panel 
            GroupControl grpEditCustomDic = optionsForm.Controls.Find("grpEditCustomDic", true)[0] as GroupControl;
            grpEditCustomDic.Visible = false;
            optionsForm.Controls.Find("grpInternationDocs", true)[0].Top = grpEditCustomDic.Top;
            optionsForm.Controls.Find("xtraTabControl1", true)[0].Height -= grpEditCustomDic.Height;
            optionsForm.Height -= grpEditCustomDic.Height;

        }
        #endregion #OptionsFormShowingEvent
    }
}
