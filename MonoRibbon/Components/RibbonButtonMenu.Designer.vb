Imports System.Windows.Forms

Namespace RibbonComponents
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RibbonButtonMenu
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
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 1)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(150, 150)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'Button1
            '
            Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Button1.Location = New System.Drawing.Point(3, 0)
            Me.Button1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(144, 130)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Button2.Location = New System.Drawing.Point(3, 130)
            Me.Button2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(144, 20)
            Me.Button2.TabIndex = 1
            Me.Button2.Text = "▼"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'RibbonButtonMenu
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "RibbonButtonMenu"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Button1 As Button
        Friend WithEvents Button2 As Button
    End Class
End Namespace
