﻿Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RibbonButtonP
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 150)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RibbonButtonP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Name = "RibbonButtonP"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
End Class