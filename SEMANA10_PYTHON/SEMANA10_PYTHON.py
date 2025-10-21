from unittest import case
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
        opc = int(input("Ingrese una opcion: \n"))

        if opc in (1,2,3,4):
            break
        else: print("Opcion no valida. Ingrese un numero nuevamente.\n")

    match opc:
        case 1: print("\nSaldo disponible:)",c.consutar())
        case 2: 
            monto = input ("\nIngrese el monto a depositar: ")
            c.depositar(monto)
        case 3: print("\nRetirar")
        case 4: quit()

    while True:
        conti = input("\nDesea continuar? (S/N): ").lower()

        if conti in ("S", "N"): break
        else: print("Error. Presione solo 's' o 'n' .")
