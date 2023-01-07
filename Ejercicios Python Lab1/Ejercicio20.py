def calculadorTriangulo():
    """"
    Se crea la función el cálculo del área y perímetro del triangulo que haya elegido el usuario.
    .
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    print("-----Bienvenido a la calculadora de área y perímetro del triangulo-----")
    #Almaceno la base.
    print('\nIngrese la base del triangulo')
    base = float(input())
    #Almaceno la altura.
    print('\nIngrese la altura del triangulo')
    altura = float(input())
    #Genero una condición if para asegurarme que no ingrese un valor negativo en la base y altura ya que esto no es posible.
    if(base >= 0 and altura >=0):
        #Realizo el cálculo del área para luego mostrarlo en pantalla.
        area = (base*altura)/2
        print("\n")
        print('El área del triangulo es',area)
        #Realizo el cálculo del perímetro para luego mostrarlo en pantalla.
        perimetro = base+(altura*2)
        print("\n")
        print('El perímetro del triangulo es',perimetro)
    else:
        print('Ingrese un valor correcto')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    calculadorTriangulo()