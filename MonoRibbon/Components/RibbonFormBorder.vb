Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design

Namespace RibbonComponents
    <Designer(GetType(MyUserControlDesignerA))>
    Public Class RibbonFormBorder : Inherits UserControl

        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Property ContentsPanel As Panel
            Get
                Return Panel1
            End Get
            Set(value As Panel)
                If IsNothing(value) = False Then
                    Panel1 = value
                End If
            End Set
        End Property

        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("Color of the font.")>
        Public Property FontColor As Color
            Get
                Return FontColorB
            End Get
            Set(value As Color)
                FontColorB = value
                Label1.ForeColor = value
                Label2.ForeColor = value
                Button2.ForeColor = value
                Button3.ForeColor = value
            End Set
        End Property
        Dim FontColorB As Color

        <System.ComponentModel.Category("Ribbon")>
        <System.ComponentModel.Description("Color of the font.")>
        Public Property BorderBackColor As Color
            Get
                Return BorderBackColorB
            End Get
            Set(value As Color)
                BorderBackColorB = value
                Label1.BackColor = value
                Label2.BackColor = value
                Button2.BackColor = value
                Button3.BackColor = value
                Panel1.BackColor = value
            End Set
        End Property
        Dim BorderBackColorB As Color

        Dim drag As Boolean
        Dim mousex As Integer
        Dim mousey As Integer
        Dim WithEvents formOri As Form
        Private Sub RibbonFormBorder_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Label1.MouseDown
            drag = True 'Sets the variable drag to true.
            formOri = GetParentForm(Me)
            If formOri IsNot Nothing Then
                mousex = Cursor.Position.X - formOri.Left 'Sets variable mousex
                mousey = Cursor.Position.Y - formOri.Top 'Sets variable mousey
            End If
        End Sub

        Private Sub RibbonFormBorder_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Label1.MouseMove
            'If drag is set to true then move the form accordingly.
            If drag Then
                If formOri IsNot Nothing Then
                    formOri.Top = Cursor.Position.Y - mousey
                    formOri.Left = Cursor.Position.X - mousex
                End If
            End If
        End Sub

        Private Function GetParentForm(ByVal parent As Control) As Form
            Dim form As Form = TryCast(parent, Form)

            If form IsNot Nothing Then
                Return form
            End If

            If parent IsNot Nothing Then
                Return GetParentForm(parent.Parent)
            End If

            Return Nothing
        End Function

        Private Sub RibbonFormBorder_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, Label1.MouseUp
            drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
        End Sub

        Public Sub New()
            MyBase.New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.Dock = DockStyle.Top
            '🗙︎ 🗖︎ 🗗︎ 🗕︎
            formOri = GetParentForm(Me)
            If formOri IsNot Nothing Then
                Select Case formOri.WindowState
                    Case FormWindowState.Normal
                        Button2.Text = "🗖︎"
                    Case FormWindowState.Maximized
                        Button2.Text = "🗗︎"
                End Select
                Label1.Text = formOri.Text
            Else
                If System.Environment.OSVersion.Platform = PlatformID.Unix Then
                    Button2.Text = "▄"
                Else
                    Button2.Text = "🗖"
                End If
            End If
        End Sub


        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            formOri = GetParentForm(Me)
            If formOri IsNot Nothing Then
                Select Case formOri.WindowState
                    Case FormWindowState.Maximized

                        If System.Environment.OSVersion.Platform = PlatformID.Unix Then
                            Button2.Text = "▄"
                        Else
                            Button2.Text = "🗖"
                        End If
                        '▄
                        formOri.WindowState = FormWindowState.Normal
                    Case FormWindowState.Normal
                        '█

                        If System.Environment.OSVersion.Platform = PlatformID.Unix Then
                            Button2.Text = "█"
                        Else
                            Button2.Text = "🗗"
                        End If

                        formOri.WindowState = FormWindowState.Maximized


                End Select
                Label1.Text = formOri.Text
            End If
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            formOri = GetParentForm(Me)
            If formOri IsNot Nothing Then
                'Select Case formOri.WindowState
                '    Case FormWindowState.Maximized
                '        Button2.Text = "🗗︎"
                '        formOri.WindowState = FormWindowState.Normal
                '    Case FormWindowState.Normal
                '        Button2.Text = "🗖︎"
                '        formOri.WindowState = FormWindowState.Maximized
                'End Select
                formOri.WindowState = FormWindowState.Minimized
                Label1.Text = formOri.Text
            End If
        End Sub

        Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
            formOri = GetParentForm(Me)
            If formOri IsNot Nothing Then
                formOri.Close()
            End If
        End Sub

        Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
            Label2.BackColor = Color.Red
        End Sub

        Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave

            Dim colo As Color
            If IsNothing(BorderBackColorB) Then
                colo = System.Drawing.SystemColors.Control
            Else
                colo = BorderBackColorB
            End If

            Label2.BackColor = colo
        End Sub


        Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
            Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        End Sub

        Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
            Dim colo As Color
            If IsNothing(BorderBackColorB) Then
                colo = System.Drawing.SystemColors.Control
            Else
                colo = BorderBackColorB
            End If

            Button2.BackColor = colo ' System.Drawing.SystemColors.Control
        End Sub

        Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
            Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        End Sub

        Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
            Dim colo As Color
            If IsNothing(BorderBackColorB) Then
                colo = System.Drawing.SystemColors.Control
            Else
                colo = BorderBackColorB
            End If
            Button3.BackColor = colo 'System.Drawing.SystemColors.Control
        End Sub

        Private Sub formOri_TextChanged(sender As Object, e As EventArgs) Handles formOri.TextChanged
            Label1.Text = formOri.Text
        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub
    End Class

    Public Class MyUserControlDesignerA
        Inherits ParentControlDesigner

        Public Overrides Sub Initialize(ByVal component As IComponent)
            MyBase.Initialize(component)
            'Dim contentsPanel = (CType(Me.Control, RibbonPanelP)).ContentsPanel
            Dim objeto As RibbonFormBorder = Me.Control
            Dim contentsPanel = objeto.ContentsPanel
            Me.EnableDesignMode(contentsPanel, "ContentsPanel")
            objeto.Dock = DockStyle.Top
        End Sub

        Public Overrides Function CanParent(ByVal control As Control) As Boolean
            Return False
        End Function

        Protected Overrides Sub OnDragOver(ByVal de As DragEventArgs)
            de.Effect = DragDropEffects.None
        End Sub

        Protected Overrides Function CreateToolCore(ByVal tool As ToolboxItem, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal hasLocation As Boolean, ByVal hasSize As Boolean) As IComponent()
            Return Nothing
        End Function
    End Class
End Namespace
