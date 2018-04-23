Namespace SpellingFormShowingEvents
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim spellCheckerOpenOfficeDictionary1 As New DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.spellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.memoEdit1.Location = New System.Drawing.Point(103, 12)
            Me.memoEdit1.Name = "memoEdit1"
            Me.spellChecker1.SetShowSpellCheckMenu(Me.memoEdit1, True)
            Me.memoEdit1.Size = New System.Drawing.Size(343, 375)
            Me.spellChecker1.SetSpellCheckerOptions(Me.memoEdit1, optionsSpelling1)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 13)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "Check Spelling"
            ' 
            ' spellChecker1
            ' 
            Me.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
            Me.spellChecker1.Culture = New System.Globalization.CultureInfo("en-US")
            spellCheckerOpenOfficeDictionary1.AlphabetPath = "EnglishAlphabet.txt"
            spellCheckerOpenOfficeDictionary1.CacheKey = Nothing
            spellCheckerOpenOfficeDictionary1.Culture = New System.Globalization.CultureInfo("en-US")
            spellCheckerOpenOfficeDictionary1.DictionaryPath = "en_US.dic"
            spellCheckerOpenOfficeDictionary1.Encoding = System.Text.Encoding.GetEncoding(1251)
            spellCheckerOpenOfficeDictionary1.GrammarPath = "en_US.aff"
            Me.spellChecker1.Dictionaries.Add(spellCheckerOpenOfficeDictionary1)
            Me.spellChecker1.ParentContainer = Nothing
            Me.spellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(458, 399)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.memoEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private WithEvents spellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

