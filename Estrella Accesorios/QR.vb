Public Class QR
	Public Overloads Function Generar_QR(Texto As String, Tamano As Integer) As Bitmap
		Try
			Dim qrGenerator As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator
			Dim qrCodeData As QRCoder.QRCodeData = qrGenerator.CreateQrCode(Texto, QRCoder.QRCodeGenerator.ECCLevel.Q)
			Dim qrCode As QRCoder.QRCode = New QRCoder.QRCode(qrCodeData)

			Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano)

			Return qrCodeImage
		Catch ex As Exception
			Return Nothing
		End Try
	End Function

	Public Overloads Function Generar_QR(ByVal Texto As String, ByVal Tamano As Integer, ByVal HtmlHexColor1 As String, ByVal HtmlHexColor2 As String) As Bitmap
		Try
			Dim qrGenerator As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator
			Dim qrCodeData As QRCoder.QRCodeData = qrGenerator.CreateQrCode(Texto, QRCoder.QRCodeGenerator.ECCLevel.Q)
			Dim qrCode As QRCoder.QRCode = New QRCoder.QRCode(qrCodeData)

			Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano, HtmlHexColor1, HtmlHexColor2)

			Return qrCodeImage
		Catch ex As Exception
			Return Nothing
		End Try
	End Function

	Public Overloads Function Generar_QR(ByVal Texto As String, ByVal Tamano As Integer, ByVal Color1 As Color, ByVal Color2 As Color) As Bitmap
		Try
			Dim qrGenerator As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator
			Dim qrCodeData As QRCoder.QRCodeData = qrGenerator.CreateQrCode(Texto, QRCoder.QRCodeGenerator.ECCLevel.Q)
			Dim qrCode As QRCoder.QRCode = New QRCoder.QRCode(qrCodeData)

			Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano, Color1, Color2, True)

			Return qrCodeImage
		Catch ex As Exception
			Return Nothing
		End Try
	End Function

	Public Overloads Function Generar_QR(ByVal Texto As String, ByVal Tamano As Integer, ByVal Color1 As Color, ByVal Color2 As Color, ByVal Archivo As String) As Bitmap
		Try
			Dim qrGenerator As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator
			Dim qrCodeData As QRCoder.QRCodeData = qrGenerator.CreateQrCode(Texto, QRCoder.QRCodeGenerator.ECCLevel.Q)
			Dim qrCode As QRCoder.QRCode = New QRCoder.QRCode(qrCodeData)

			Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano, Color1, Color2, Bitmap.FromFile(Archivo))

			Return qrCodeImage
		Catch ex As Exception
			Return Nothing
		End Try
	End Function

	'stringVar QRFormat;
	'stringVar QRwidth;
	'stringVar QRheight;
	'stringVar QRText;
	'stringVar QRURI;

	'// Encoding format see google's api
	'QRFormat := 'UTF-8';

	'// Width in Pixels
	'QRwidth := '250';

	'// Height in Pixels
	'QRheight := '250';

	'// Text for the QR Code.
	'//
	'// 
	'QRText := {Articulos.art_codigo_barras};

	'// To Do
	'// StringReplace for URI

	'// Combine the result 
	'// 
	'// Base URI must be http://
	'// Or Crystal cannot fetch
	'// the image
	'QRURI := 'http://chart.googleapis.com/chart?cht=qr&choe='+QRFormat+'&chs='+QRWidth+'x'+QRHeight+'&chl='+QRText;

	'QRURI;

	'//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	'Dim qrGenerator As QRCoder.QRCodeGenerator = New QRCoder.QRCodeGenerator
	'Dim qrCodeData As QRCoder.QRCodeData = qrGenerator.CreateQrCode(Texto, QRCoder.QRCodeGenerator.ECCLevel.Q)
	'Dim qrCode As QRCoder.QRCode = New QRCoder.QRCode(qrCodeData)

	'QR by Pixel
	'Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano)

	'Set color by using Color-class types
	'Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano, Color.DarkRed, Color.PaleGreen, True)

	'Set color by using HTML hex color notation
	'Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano, "#000ff0", "#0ff000")

	'The another overload enables you to render a logo/image in the center of the QR code.

	'Dim qrCodeImage As Bitmap = qrCode.GetGraphic(Tamano, Color.Black, Color.White, Bitmap.FromFile("C:\\myimage.png"))
End Class
