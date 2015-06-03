<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Lancer = New System.Windows.Forms.Button()
        Me.LRText = New System.Windows.Forms.Label()
        Me.LRInt = New System.Windows.Forms.Label()
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.ScoreInt = New System.Windows.Forms.Label()
        Me.de = New System.Windows.Forms.Label()
        Me.Auteur = New System.Windows.Forms.Label()
        Me.Reinit = New System.Windows.Forms.Button()
        Me.de1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lancer
        '
        Me.Lancer.Location = New System.Drawing.Point(69, 182)
        Me.Lancer.Name = "Lancer"
        Me.Lancer.Padding = New System.Windows.Forms.Padding(1)
        Me.Lancer.Size = New System.Drawing.Size(202, 51)
        Me.Lancer.TabIndex = 1
        Me.Lancer.Text = "Lancer"
        Me.Lancer.UseVisualStyleBackColor = True
        '
        'LRText
        '
        Me.LRText.AutoSize = True
        Me.LRText.Location = New System.Drawing.Point(30, 289)
        Me.LRText.Name = "LRText"
        Me.LRText.Size = New System.Drawing.Size(50, 26)
        Me.LRText.TabIndex = 2
        Me.LRText.Text = "lancer(s)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "restant(s)"
        '
        'LRInt
        '
        Me.LRInt.AutoSize = True
        Me.LRInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRInt.Location = New System.Drawing.Point(30, 335)
        Me.LRInt.Name = "LRInt"
        Me.LRInt.Size = New System.Drawing.Size(17, 17)
        Me.LRInt.TabIndex = 3
        Me.LRInt.Text = "5"
        '
        'ScoreText
        '
        Me.ScoreText.AutoSize = True
        Me.ScoreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.Location = New System.Drawing.Point(275, 302)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(66, 20)
        Me.ScoreText.TabIndex = 4
        Me.ScoreText.Text = "Score :"
        '
        'ScoreInt
        '
        Me.ScoreInt.AutoSize = True
        Me.ScoreInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreInt.Location = New System.Drawing.Point(276, 335)
        Me.ScoreInt.Name = "ScoreInt"
        Me.ScoreInt.Size = New System.Drawing.Size(17, 17)
        Me.ScoreInt.TabIndex = 5
        Me.ScoreInt.Text = "0"
        '
        'de
        '
        Me.de.AutoSize = True
        Me.de.Location = New System.Drawing.Point(46, 30)
        Me.de.MaximumSize = New System.Drawing.Size(55, 55)
        Me.de.MinimumSize = New System.Drawing.Size(55, 55)
        Me.de.Name = "de"
        Me.de.Padding = New System.Windows.Forms.Padding(1)
        Me.de.Size = New System.Drawing.Size(55, 55)
        Me.de.TabIndex = 6
        '
        'Auteur
        '
        Me.Auteur.AutoSize = True
        Me.Auteur.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auteur.Location = New System.Drawing.Point(145, 371)
        Me.Auteur.Name = "Auteur"
        Me.Auteur.Size = New System.Drawing.Size(221, 19)
        Me.Auteur.TabIndex = 7
        Me.Auteur.Text = "Made By Joseph Pascal NOMO"
        '
        'Reinit
        '
        Me.Reinit.Location = New System.Drawing.Point(279, 196)
        Me.Reinit.Name = "Reinit"
        Me.Reinit.Size = New System.Drawing.Size(87, 23)
        Me.Reinit.TabIndex = 8
        Me.Reinit.Text = "Réinitialisation"
        Me.Reinit.UseVisualStyleBackColor = True
        '
        'de1
        '
        Me.de1.AutoSize = True
        Me.de1.Location = New System.Drawing.Point(228, 30)
        Me.de1.MaximumSize = New System.Drawing.Size(55, 55)
        Me.de1.MinimumSize = New System.Drawing.Size(55, 55)
        Me.de1.Name = "de1"
        Me.de1.Padding = New System.Windows.Forms.Padding(1)
        Me.de1.Size = New System.Drawing.Size(55, 55)
        Me.de1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(371, 399)
        Me.Controls.Add(Me.de1)
        Me.Controls.Add(Me.Reinit)
        Me.Controls.Add(Me.Auteur)
        Me.Controls.Add(Me.de)
        Me.Controls.Add(Me.ScoreInt)
        Me.Controls.Add(Me.ScoreText)
        Me.Controls.Add(Me.LRInt)
        Me.Controls.Add(Me.LRText)
        Me.Controls.Add(Me.Lancer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(387, 437)
        Me.MinimumSize = New System.Drawing.Size(387, 437)
        Me.Name = "Form1"
        Me.Text = "Lancé de dé"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lancer As System.Windows.Forms.Button
    Friend WithEvents LRText As System.Windows.Forms.Label
    Friend WithEvents LRInt As System.Windows.Forms.Label
    Friend WithEvents ScoreText As System.Windows.Forms.Label
    Friend WithEvents ScoreInt As System.Windows.Forms.Label
    Friend WithEvents de As System.Windows.Forms.Label
    Friend WithEvents Auteur As System.Windows.Forms.Label
    Friend WithEvents Reinit As System.Windows.Forms.Button
    Friend WithEvents de1 As System.Windows.Forms.Label

End Class
