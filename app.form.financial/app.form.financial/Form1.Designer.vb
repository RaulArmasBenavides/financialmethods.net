﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FUNCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAYMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANZASFUNCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DICCIONARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJEMPLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENUMERATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASPOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FUNCIONESToolStripMenuItem, Me.DICCIONARIOToolStripMenuItem, Me.ASPOSEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1441, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FUNCIONESToolStripMenuItem
        '
        Me.FUNCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RATEToolStripMenuItem, Me.PAYMENTToolStripMenuItem, Me.FINANZASFUNCIONESToolStripMenuItem})
        Me.FUNCIONESToolStripMenuItem.Name = "FUNCIONESToolStripMenuItem"
        Me.FUNCIONESToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.FUNCIONESToolStripMenuItem.Text = "FINANCIAL METHODS"
        '
        'RATEToolStripMenuItem
        '
        Me.RATEToolStripMenuItem.Name = "RATEToolStripMenuItem"
        Me.RATEToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RATEToolStripMenuItem.Text = "RATE"
        '
        'PAYMENTToolStripMenuItem
        '
        Me.PAYMENTToolStripMenuItem.Name = "PAYMENTToolStripMenuItem"
        Me.PAYMENTToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PAYMENTToolStripMenuItem.Text = "PAYMENT"
        '
        'FINANZASFUNCIONESToolStripMenuItem
        '
        Me.FINANZASFUNCIONESToolStripMenuItem.Name = "FINANZASFUNCIONESToolStripMenuItem"
        Me.FINANZASFUNCIONESToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FINANZASFUNCIONESToolStripMenuItem.Text = "X"
        '
        'DICCIONARIOToolStripMenuItem
        '
        Me.DICCIONARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EJEMPLOToolStripMenuItem, Me.ENUMERATIONToolStripMenuItem})
        Me.DICCIONARIOToolStripMenuItem.Name = "DICCIONARIOToolStripMenuItem"
        Me.DICCIONARIOToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.DICCIONARIOToolStripMenuItem.Text = "DICTIONARY"
        '
        'EJEMPLOToolStripMenuItem
        '
        Me.EJEMPLOToolStripMenuItem.Name = "EJEMPLOToolStripMenuItem"
        Me.EJEMPLOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EJEMPLOToolStripMenuItem.Text = "SAMPLE"
        '
        'ENUMERATIONToolStripMenuItem
        '
        Me.ENUMERATIONToolStripMenuItem.Name = "ENUMERATIONToolStripMenuItem"
        Me.ENUMERATIONToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ENUMERATIONToolStripMenuItem.Text = "ENUMERATION"
        '
        'ASPOSEToolStripMenuItem
        '
        Me.ASPOSEToolStripMenuItem.Name = "ASPOSEToolStripMenuItem"
        Me.ASPOSEToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ASPOSEToolStripMenuItem.Text = "DOCUMENTS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 545)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FUNCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAYMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DICCIONARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJEMPLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENUMERATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FINANZASFUNCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASPOSEToolStripMenuItem As ToolStripMenuItem
End Class
