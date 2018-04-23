Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace SpellingFormShowingEvents
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            spellChecker1.Check(memoEdit1)
        End Sub

        #Region "#SpellingFormShowingEvent"
        Private Sub spellChecker1_SpellingFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraSpellChecker.SpellingFormShowingEventArgs) Handles spellChecker1.SpellingFormShowing
            Dim spellDialogForm = spellChecker1.FormsManager.SpellCheckForm

            spellDialogForm.Controls("btnIgnore").Enabled = False
            spellDialogForm.Controls("btnIgnoreAll").Visible = False
            spellDialogForm.Controls("btnChangeAll").Visible = False
            spellDialogForm.Controls.Add(New SimpleButton() With {.Text = "Custom Button", .Size = New Size(100, 25), .Location = New Point(10, 150)})
        End Sub
        #End Region ' #SpellingFormShowingEvent

        #Region "#OptionsFormShowingEvent"
        Private Sub spellChecker1_OptionsFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraSpellChecker.FormShowingEventArgs) Handles spellChecker1.OptionsFormShowing
            Dim optionsForm = spellChecker1.FormsManager.OptionsForm
            ' You can hide the 'Add' button 
            spellChecker1.FormsManager.SpellCheckForm.Controls("btnAdd").Visible = False

            ' Or suppress the entire panel 
            Dim grpEditCustomDic As GroupControl = TryCast(optionsForm.Controls.Find("grpEditCustomDic", True)(0), GroupControl)
            grpEditCustomDic.Visible = False
            optionsForm.Controls.Find("grpInternationDocs", True)(0).Top = grpEditCustomDic.Top
            optionsForm.Controls.Find("xtraTabControl1", True)(0).Height -= grpEditCustomDic.Height
            optionsForm.Height -= grpEditCustomDic.Height

        End Sub
        #End Region ' #OptionsFormShowingEvent
    End Class
End Namespace
