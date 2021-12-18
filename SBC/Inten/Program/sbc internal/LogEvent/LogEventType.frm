VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3015
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   3015
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command3 
      Caption         =   "Command3"
      Height          =   255
      Left            =   600
      TabIndex        =   2
      Top             =   1440
      Width           =   1335
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Command2"
      Height          =   255
      Left            =   480
      TabIndex        =   1
      Top             =   960
      Width           =   1455
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Command1"
      Height          =   375
      Left            =   480
      TabIndex        =   0
      Top             =   360
      Width           =   1455
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
App.LogEvent "This is a new message ", vbLogEventTypeInformation
End Sub

Private Sub Command2_Click()
App.LogEvent "Warning has been generated ", vbLogEventTypeWarning
End Sub

Private Sub Command3_Click()
App.LogEvent "Error message has been generated ", vbLogEventTypeError
End Sub

Private Sub Form_Load()
Command1.Caption = "Information"
Command2.Caption = "Warning"
Command3.Caption = "Error"
End Sub
