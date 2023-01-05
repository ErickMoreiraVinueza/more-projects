def leerVariables():
    """"
    Se crea la función para la lectura del número de triángulos para los que se desea calcular el teorema de pitágoras elegidos por el 
    usuario para que sea de manera genérica.
    
    Parámetros:
    -------------------
    No recibe ningún valor.

    Retorna:
    -------------------
    Retorna la variable num_triangulos que ha digitado el usuario.
    """
    #Solicito al usuario el número de veces para los que desea hacer los cálculos.
    num_triangulos = int(input('Ingrese el número de triangulos para los que desea calcular el teorema de pitágoras: '))
    #Retorno la variable para usarla como parámetro en la siguiente función.
    return num_triangulos

def calculadorPitagoras(num_triangulos):
    """"
    Se crea la función el cálculo del teorema según los triangulos que haya elegido el usuario.
  
    Parámetros:
    -------------------
    Recibe la variable num_triangulos correspondiente a las veces que se desee calcular.

    Retorna:
    -------------------
    No retorna ningún valor.
    """    
    #Genero una condición if para asegurarme que al menos debe ingresar los datos una vez, y para que no permita ingresar 
    #números negativos dado que eso no tendría sentido.
    if(num_triangulos >= 1):
        #Genero mi ciclo for que es el encargado de ir pidiendo los datos correspondientes, donde este se va a detener hasta el número
        #de triángulos que haya digitado el usuario.
        for i in range(0,num_triangulos):
            #Almaceno el valor del cateto1.
            print('\nIngrese el valor del cateto 1 del triángulo',i+1,':')
            cateto1= float(input())
            #Almaceno el cateto2.
            print('\nIngrese el valor del cateto 2 del triángulo',i+1,':')
            cateto2 = float(input())
            #Condición para que no pueda ingresar catetos negativos, ya que eso sería incorrecto.
            if(cateto1 >= 0 and cateto2 >= 0):
                #Calculo de la hipotenusa y luego lo muestro en pantalla.
                hipotenusa = (cateto1*cateto1) + (cateto2*cateto2)
                hipotenusa = hipotenusa**0.5
                print('El resultado de la hipotenusa del triángulo',i+1,"es",hipotenusa)
            else:
                print('No puede haber un cateto negativo, intente nuevamente')
                break
    else:
        print('Ingrese un valor correcto, recuerde que debe haber mínimo una expresión')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    num_triangulo = leerVariables()
    calculadorPitagoras(num_triangulo)