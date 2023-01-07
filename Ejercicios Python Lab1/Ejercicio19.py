def leerVariables():
    """"
    Se crea la función para la lectura del número veces que se desea calcular la expresión correspondiente elegidos por el usuario para 
    que sea de manera genérica.
    
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

def calculadorExpresion(num_expresiones):
    """"
    Se crea la función el cálculo de la expresión según las veces que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable num_expresiones correspondiente a las veces que se desee calcular.

    Retorna:
    -------------------
    No retorna ningún valor.
    """    
    #Genero una condición if para asegurarme que al menos debe ingresar los datos una vez, y para que no permita ingresar 
    #números negativos dado que eso no tendría sentido.
    if(num_expresiones >= 1):
        #Genero mi ciclo for que es el encargado de ir pidiendo los datos correspondientes, donde este se va a detener hasta el número
        #de expresiones que haya digitado el usuario.
        for i in range(0,num_expresiones):
            #Almaceno el valor de la base.
            print('\nIngrese el valor de x de la expresión',i+1,':')
            base = float(input())
            #Almaceno el valor del del exponente.
            print('\nIngrese el valor de y de la expresión',i+1,':')
            exponente = float(input())
            #Calculo el valor y luego lo muestro en pantalla.
            resultado = base**exponente
            print('El resultado de la expresión',i+1,"es",resultado)
    else:
        print('Ingrese un valor correcto, recuerde que debe haber mínimo una expresión')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    num_expresiones = leerVariables()
    calculadorExpresion(num_expresiones)