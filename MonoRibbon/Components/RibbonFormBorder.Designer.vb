
Namespace RibbonComponents
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RibbonFormBorder
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button2 = New System.Windows.Forms.Label()
            Me.Button3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.MinimumSize = New System.Drawing.Size(50, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(123, 49)
            Me.Panel1.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(466, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(50, 49)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "✖"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Button2
            '
            Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button2.Location = New System.Drawing.Point(434, 0)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(32, 49)
            Me.Button2.TabIndex = 6
            Me.Button2.Text = "🗗"
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Button3
            '
            Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Button3.Location = New System.Drawing.Point(404, 0)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(30, 49)
            Me.Button3.TabIndex = 7
            Me.Button3.Text = "_"
            Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Location = New System.Drawing.Point(123, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(281, 49)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Label1"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'RibbonFormBorder
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Label2)
            Me.Name = "RibbonFormBorder"
            Me.Size = New System.Drawing.Size(516, 49)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As Windows.Forms.Panel
        Friend WithEvents Label2 As Windows.Forms.Label
        Friend WithEvents Button2 As Windows.Forms.Label
        Friend WithEvents Button3 As Windows.Forms.Label
        Friend WithEvents Label1 As Windows.Forms.Label
    End Class
End Namespace
