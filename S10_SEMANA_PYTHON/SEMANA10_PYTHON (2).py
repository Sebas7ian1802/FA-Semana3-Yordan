from Cajero import Cajero
c=Cajero()

conti = "S"

while conti == "S":
    print("BIENVENIDOS AL SISTEMA CAJERO\n")
    print("1. Consultar saldo")
    print("2. Depositar")
    print("3. Retirar")
    print("4. Salir")

    while True:
        opc = int(input("Ingrese una opcion: "))

        if opc in (1,2,3,4):
            break
        else: print("Opcion no valida. Ingrese un numero nuevamente.\n")
