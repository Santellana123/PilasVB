Imports System
Imports System.Collections.Generic
Module Program
    Sub Main(args As String())
        Dim miPila As New Stack(Of Integer)()
        Dim a As Integer = 1
        Dim elementoAgregar As Integer ' Declarar la variable aquí

        While a = 1
            Console.WriteLine(vbCrLf & "Operaciones disponibles:")
            Console.WriteLine("1. Agregar elemento a la pila")
            Console.WriteLine("2. Quitar elemento de la pila")
            Console.WriteLine("3. Mostrar elemento superior de la pila (sin quitar)")
            Console.WriteLine("4. Mostrar todos los elementos de la pila")
            Console.WriteLine("5. Salir")

            Console.Write("Seleccione una operación (1-5): ")
            Dim opcion As String = Console.ReadLine()
            Console.Clear()

            Select Case opcion
                Case "1"
                    Console.Write("Ingrese el elemento a agregar a la pila: ")
                    Dim entrada As String = Console.ReadLine()
                    If Integer.TryParse(entrada, elementoAgregar) Then
                        miPila.Push(elementoAgregar)
                        Console.WriteLine($"Elemento {elementoAgregar} agregado a la pila.")
                    Else
                        Console.WriteLine("Entrada no válida. Ingrese un número entero.")
                    End If

                Case "2"
                    If miPila.Count > 0 Then
                        Dim elementoQuitar As Integer = miPila.Pop()
                        Console.WriteLine($"Elemento {elementoQuitar} quitado de la pila.")
                    Else
                        Console.WriteLine("La pila está vacía. No se puede quitar ningún elemento.")
                    End If

                Case "3"
                    If miPila.Count > 0 Then
                        Dim elementoSuperiorPeek As Integer = miPila.Peek()
                        Console.WriteLine($"Elemento superior de la pila (sin quitar): {elementoSuperiorPeek}")
                    Else
                        Console.WriteLine("La pila está vacía. No hay elementos para mostrar.")
                    End If

                Case "4"
                    Console.WriteLine("Elementos en la pila:")
                    For Each elemento As Integer In miPila
                        Console.WriteLine(elemento)
                    Next

                Case "5"
                    Console.WriteLine("Saliendo del programa.")
                    a = 2

                Case Else
                    Console.WriteLine("Opción no válida. Intente de nuevo.")
            End Select
        End While
    End Sub
End Module
