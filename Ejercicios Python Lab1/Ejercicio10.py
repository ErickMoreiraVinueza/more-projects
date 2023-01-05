def calculadorCilindro():
    """"
    Se crea la función el cálculo del volumen y área del cilindro que haya elegido el usuario.
    .
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    print("-----Bienvenido a la calculadora de área y altura de un cilindro-----")
    #Almaceno el radio.
    print('\nIngrese el radio del cilindro')
    radio = float(input())
    #Almaceno la altura.
    print('\nIngrese la altura del cilindro:')
    altura = float(input())
    #Genero una condición if para asegurarme que no ingrese valores negativos en la altura o el radio ya que esto no es 
    #posible.
    if(radio and altura >= 0):
        #Realizo el cálculo del área para luego mostrarlo en pantalla.
        area = 2*3.1416*radio*(radio+altura)
        print("\n")
        print('El área del cilindro es',area)
        #Realizo el cálculo del volumen para luego mostrarlo en pantalla.
        volumen = 3.1416*(radio*radio)*altura
        print("\n")
        print('El volumen del cilindro es',volumen)
    else:
        print('Ingrese un valor correcto')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    calculadorCilindro()