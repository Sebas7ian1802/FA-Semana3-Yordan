
def ejer1():

  #1.Desarrollar un programa que solicite tu nombre y carrera y luego imprima “<Tu
  #nombre >, Bienvenido al curso de Fundamentos de Algoritmos de la carrera<Tu
  #carrera>”.

    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de fudamentos de algoritmo de la carrera {carrera}")

def ejer2():

  #2.Desarrollar un algoritmo que te permita imprimir tu nombre entre comillas
  #dobles.

    print("\"Yordan\"")

def ejer3():

  # 3.Solicitar al usuario dos números enteros y realizar las siguientes operaciones:
  # • Suma.
  # • Resta.
  # • Multiplicación.
  # • División.

    num1 = int(input("Ingrese numero 1: "))
    num2 = int(input("Ingrese numero 2: "))

    print("Suma: ", (num1+num2))
    print("Resta: ", (num1-num2))
    print("Multiplicacion: ", (num1*num2))
    print("Division: ", (num1/num2))

import math #importando libreria math

def ejer4():

  # 4.Solicitar al usuario un número decimal(ej. 12.75) y calcular:
  # • Su raíz cuadrada.
  # • El valor redondeado sin decimales.
  # • El resultado de elevar el número al cubo.
  # • Su raíz cubica.

    num = float(input("Ingrese numero decimal: "))

    raiz = math.sqrt(num)
    redo = round(num,2)
    cubo = math.pow(num,3)
    cubica = num ** (1/3)

    print("Raiz cuadrada: ",raiz)
    print("Redondeado: ",redo)
    print("Al cubo: ",cubo)
    print("Raiz cubica: ",cubica)

def ejer5():

  # 5.Solicitar al usuario que ingrese un número en formato de texto(string) y
  # convertirlo a:
  # • Entero y mostrar su resto al dividir entre 2.
  # • Decimal y dividirlo entre 3.

    num = input("Ingrese un numero: ")

    entero = int(num)
    decim = float(num)

    print("Resto: ", (entero%2))
    print("Resto: ", (decim/3))

ejer5()