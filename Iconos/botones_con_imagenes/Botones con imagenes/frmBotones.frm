VERSION 5.00
Begin VB.Form frmBotones 
   Caption         =   "Botones con Imagenes"
   ClientHeight    =   2625
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5925
   LinkTopic       =   "Form1"
   ScaleHeight     =   2625
   ScaleWidth      =   5925
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdBuscar 
      Caption         =   "&Buscar"
      Height          =   630
      Left            =   1710
      Picture         =   "frmBotones.frx":0000
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   150
      Width           =   800
   End
   Begin VB.CommandButton cmdTiempo 
      Caption         =   "Tiempo"
      Height          =   630
      Left            =   3480
      Picture         =   "frmBotones.frx":0102
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   150
      Width           =   855
   End
   Begin VB.CommandButton cmdCancelar 
      Caption         =   "Cancelar"
      Height          =   630
      Left            =   5070
      Picture         =   "frmBotones.frx":068C
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton cmdSalir 
      Cancel          =   -1  'True
      Caption         =   "&Salir"
      Height          =   630
      Left            =   5070
      Picture         =   "frmBotones.frx":0C16
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdBuscaRapida 
      Caption         =   "&Buscar Rapido"
      Default         =   -1  'True
      DisabledPicture =   "frmBotones.frx":11A0
      Height          =   630
      Left            =   4290
      Picture         =   "frmBotones.frx":12A2
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Cancelar"
      DisabledPicture =   "frmBotones.frx":13A4
      Height          =   630
      Left            =   3210
      Picture         =   "frmBotones.frx":14A6
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton Command2 
      Caption         =   "&Buscar"
      DisabledPicture =   "frmBotones.frx":15A8
      Height          =   630
      Left            =   3210
      Picture         =   "frmBotones.frx":16AA
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdUltimo 
      Caption         =   "&Ultimo"
      Height          =   630
      Left            =   2430
      Picture         =   "frmBotones.frx":19EC
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdSiguiente 
      Caption         =   "&Siguiente"
      Height          =   630
      Left            =   1650
      Picture         =   "frmBotones.frx":1D2E
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdAnterior 
      Caption         =   "&Anterior"
      Height          =   630
      Left            =   870
      Picture         =   "frmBotones.frx":2070
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdPrimero 
      Caption         =   "&Primero"
      Height          =   630
      Left            =   90
      Picture         =   "frmBotones.frx":23B2
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdEliminar 
      Caption         =   "&Eliminar"
      DisabledPicture =   "frmBotones.frx":26F4
      Height          =   630
      Left            =   2430
      Picture         =   "frmBotones.frx":27F6
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton cmdEditar 
      Caption         =   "E&ditar"
      DisabledPicture =   "frmBotones.frx":28F8
      Height          =   630
      Left            =   1650
      Picture         =   "frmBotones.frx":29FA
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton cmdGrabar 
      Caption         =   "&Grabar"
      DisabledPicture =   "frmBotones.frx":2AFC
      Height          =   630
      Left            =   870
      Picture         =   "frmBotones.frx":2BFE
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Iniciar"
      Height          =   630
      Left            =   870
      Picture         =   "frmBotones.frx":2D00
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   150
      Width           =   855
   End
   Begin VB.CommandButton cmdDetener 
      Caption         =   "Detener"
      Height          =   630
      Left            =   2760
      Picture         =   "frmBotones.frx":2E4A
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   150
      Width           =   735
   End
   Begin VB.CommandButton cmdNuevo 
      Caption         =   "&Nuevo"
      DisabledPicture =   "frmBotones.frx":2F94
      Height          =   630
      Left            =   90
      Picture         =   "frmBotones.frx":3096
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   1260
      Width           =   800
   End
   Begin VB.CommandButton cmdAcerca 
      Caption         =   "&Acerca"
      Height          =   630
      Left            =   4290
      Picture         =   "frmBotones.frx":3198
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   1890
      Width           =   800
   End
   Begin VB.CommandButton cmdAceptar 
      Caption         =   "Aceptar"
      Height          =   630
      Left            =   90
      Picture         =   "frmBotones.frx":34DA
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   150
      Width           =   800
   End
   Begin VB.CommandButton cmdImprimir 
      Caption         =   "&Imprimir"
      Height          =   600
      Left            =   -3060
      Picture         =   "frmBotones.frx":3A64
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   840
      Width           =   800
   End
End
Attribute VB_Name = "frmBotones"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
