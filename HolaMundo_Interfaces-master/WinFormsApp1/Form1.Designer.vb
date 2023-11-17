<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextNom = New TextBox()
        SaludoBoton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TextNom
        ' 
        TextNom.Location = New Point(148, 82)
        TextNom.Name = "TextNom"
        TextNom.Size = New Size(100, 23)
        TextNom.TabIndex = 0
        ' 
        ' SaludoBoton
        ' 
        SaludoBoton.Location = New Point(148, 131)
        SaludoBoton.Name = "SaludoBoton"
        SaludoBoton.Size = New Size(75, 23)
        SaludoBoton.TabIndex = 1
        SaludoBoton.Text = "Saludo"
        SaludoBoton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(71, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 2
        Label1.Text = "Nombre:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(SaludoBoton)
        Controls.Add(TextNom)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextNom As TextBox
    Friend WithEvents SaludoBoton As Button
    Friend WithEvents Label1 As Label
End Class
