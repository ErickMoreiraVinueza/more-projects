def leerVariables():
    """"
    Se crea la función para la lectura del número veces que se desea calcular el área, circunferencia y diámetro del círculo elegidos 
    por el usuario para que sea de manera genérica.
    
    Parámetros:
    -------------------
    No recibe ningún valor.

    Retorna:
    -------------------
    Retorna la variable num_expresiones que ha digitado el usuario.
    """
    #Solicito al usuario el número de veces para los que desea hacer los cálculos.
    num_expresiones = int(input('Ingrese el número de veces para los que desea calcular la expresión: '))
    #Retorno la variable para usarla como parámetro en la siguiente función.
    return num_expresiones

def calculadorCirculo(num_expresiones):
    """"
    Se crea la función el cálculo del área, circunferencia y diámetro del círculo que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable num_expresiones correspondiente a las veces que se desee calcular.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    if(num_expresiones >= 1):
        print("-----Bienvenido a la calculadora del área, circunferencia y diámetro del círculo-----")
        #Genero una condición if para asegurarme que no ingrese un valor negativo en el radio ya que esto no es posible.
        for i in range(0,num_expresiones):
            #Almaceno el radio.
            print('\nIngrese el radio del círculo',i+1)
            radio = float(input())
            if(radio >= 0):
                #Realizo el cálculo del área para luego mostrarlo en pantalla.
                area = 3.1416*(radio*radio)
                print("\n")
                print('El área del círculo',i+1,"es",area)
                #Realizo el cálculo del diámetro para luego mostrarlo en pantalla.
                diametro = 2*radio
                print("\n")
                print('El diámetro del círculo',i+1,"es",diametro)
                #Realizo el cálculo de la circunferencia para luego mostrarlo en pantalla.
                cirunferencia = 2*diametro
                print("\n")
                print('La circunferencia del círculo',i+1,"es",cirunferencia)
            else:
                print('Ingrese un valor correcto')
    else:
        print("Ingrese un valor correcto, recuerde que debe haber mínimo una expresión")

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    num_expresiones = leerVariables()
    calculadorCirculo(num_expresiones)