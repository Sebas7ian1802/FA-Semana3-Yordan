class Cajero:

    saldo = 1000

    def consutar(self) -> float:
        return self.saldo

    def depositar(self, monto) -> None:
        while True:
            try:
                m = float(monto)

                if m > 0:
                    self.saldo += m
                    print("\nDepósito exitoso.")
                    break
                else:
                    print("\nError. El monto a depositar debe ser mayor a 0.")
                    break
                    
            except ValueError:
                print("\nError. Solo se permiten números")
                break

    def retirar(self, monto) -> None:
        while True:
            try:
                m = float(monto)

                if m > self.saldo:
                    print("\nError. No tienes saldo suficiente.")
                    break
                elif m <= 0:
                    print("\nError. El monto a retirar debe ser mayor a 0.")
                    break
                else: 
                    self.saldo -= m
                    print("\nRetiro exitoso.")
                    break
            except ValueError:
                print("\nError. Solo se permiten números")
                break
                
