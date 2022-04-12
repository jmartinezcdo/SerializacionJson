Imports System.IO
Imports Newtonsoft.Json

Module Module1

    Sub Main()


        'Creamos la información a serializar: 
        Console.WriteLine("Creando información...")
        Dim actualizacion1 As ActualizacionBD = New ActualizacionBD()
        actualizacion1.Fecha = New DateTime(2020, 1, 1, 14, 12, 0)
        actualizacion1.Query = "CREATE TABLE TABLA1........"

        Dim actualizacion2 As ActualizacionBD = New ActualizacionBD()
        actualizacion2.Fecha = New DateTime(2020, 1, 2, 14, 12, 0)
        actualizacion2.Query = "CREATE TABLE TABLA2........"

        'Creamos una lista que contenga las actualizaciones
        Dim actualizacionCol = New List(Of ActualizacionBD)
        actualizacionCol.Add(actualizacion1)
        actualizacionCol.Add(actualizacion2)

        'Debemos instalar un paquete de Nuget: Newtonsoft.Json
        Console.WriteLine("Serializando información....")
        Dim jsonTxt = JsonConvert.SerializeObject(actualizacionCol)
        'Guardamos el texto en un archivo. Puede llamarse de cualuqier forma y se puede poner cualquier extension
        'En este caso el archivo lleva la extensión estandar para archivos json
        Console.WriteLine("Guardando información en archivo...")
        File.WriteAllText("serializado.json", jsonTxt)

        'Para leer el archivo
        Console.WriteLine("Leyendo archivo...")
        Dim jsonTxtLeido = File.ReadAllText("serializado.json")
        Console.WriteLine("Deserializando archivo")
        Dim actualizacionCol2 As List(Of ActualizacionBD) = JsonConvert.DeserializeObject(jsonTxtLeido)

        If actualizacionCol2.Count = actualizacionCol.Count Then
            Console.WriteLine("Archivo deserializado correctamente.")
        End If


    End Sub

End Module
