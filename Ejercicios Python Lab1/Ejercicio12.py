def calculadorCirculo():
    """"
    Se crea la función el cálculo del área y perímetro del círculo que haya elegido el usuario.
    .
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    print("-----Bienvenido a la calculadora de área y perímetro del círculo-----")
    #Almaceno el radio.
    print('\nIngrese el radio del círculo')
    radio = float(input())
    #Genero una condición if para asegurarme que no ingrese un valor negativo en el radio ya que esto no es posible.
    if(radio >= 0):
        #Realizo el cálculo del área para luego mostrarlo en pantalla.
        area = 3.1416*(radio*radio)
        print("\n")
        print('El área del círculo es',area)
        #Realizo el cálculo del perímetro para luego mostrarlo en pantalla.
        perimetro = 2*3.1416*radio
        print("\n")
        print('El perímetro del círculo es',perimetro)
    else:
        print('Ingrese un valor correcto')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    calculadorCirculo()