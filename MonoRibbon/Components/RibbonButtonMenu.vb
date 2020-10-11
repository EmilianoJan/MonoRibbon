﻿Imports System.Drawing
Imports System.Windows.Forms

'<ContentProperty("MenuItems")>
Public Class RibbonButtonMenu : Inherits UserControl

    <System.ComponentModel.Category("Ribbon")>
    <System.ComponentModel.Description("Sets or gets the text show in the button")>
    Public Property ButtonText As String
        Get
            Return CaptionBack
        End Get
        Set(value As String)
            CaptionBack = value
            Button1.Text = CaptionBack
        End Set
    End Property
    Dim CaptionBack As String

    <System.ComponentModel.Category("Ribbon")>
    <System.ComponentModel.Description("Sets or gets the image of the button")>
    Public Property ButtonImage As Image
        Get
            Return ButtonImageb
        End Get
        Set(value As Image)
            'If IsNothing(value) = False Then

            'ButtonImageb = New Bitmap(value, Me.Width, Me.Height)
            'Button1.Image = ButtonImageb
            Button1.BackgroundImage = value
            Button1.BackgroundImageLayout = ImageLayout.Zoom

            'Button1.BackgroundImageLayout = ImageLayout.Center
            Button1.ImageAlign = ContentAlignment.TopCenter
            Button1.TextImageRelation = TextImageRelation.ImageAboveText
            ButtonImageb = value
            'End If
        End Set
    End Property
    Dim ButtonImageb As Image


    'Public Property ContextMenuStrip As ContextMenuStrip


    Public Event ButtonClick(sender As Object, e As EventArgs)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent ButtonClick(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pos As New Point(0, Button2.Height)

        ContextMenuStrip.Show(Button2, pos)
    End Sub
End Class