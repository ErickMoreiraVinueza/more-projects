def leerVariables():
    """"
    Se crea la función para la lectura de los números de rectángulos a ser calculados elegidos por el usuario para que sea de manera 
    genérica.
    
    Parámetros:
    -------------------
    No recibe ningún valor.

    Retorna:
    -------------------
    No retorna ningún valor dado que solo tengo que leer los datos del usuario.
    """
    #Solicito al usuario el número de rectángulos para los que desea hacer los cálculos.
    num_rectangulos = int(input('Ingrese el número de rectángulos para los que desea ingresar los lados: '))
    #Retorno la variable para usarla como parámetro en la siguiente función.
    return num_rectangulos

def calculadorPerimetro(num_rectangulos):
    """"
    Se crea la función el cálculo del perímetro de los rectángulos que haya elegido el usuario.
    .
  
    Parámetros:
    -------------------
    Recibe la variable num_rectangulos correspondiente a los rectángulos que se deseen calcular.

    Retorna:
    -------------------
    No retorna ningún valor.
    """    
    #Genero una condición if para asegurarme que al menos debe ingresar los datos de un rectángulo, y para que no permita ingresar 
    #números negativos dado que eso no tendría sentido.
    if(num_rectangulos >= 1):
        #Genero mi ciclo for que es el encargado de ir pidiendo los datos correspondientes, donde este se va a detener hasta el número
        #de rectángulos que haya digitado el usuario.
        for i in range(0,num_rectangulos):
            #Almaceno la base.
            print('\nIngrese la base del rectángulo',i+1,':')
            base = float(input())
            #Almaceno la altura.
            print('\nIngrese la altura del rectángulo',i+1,':')
            altura = float(input())
            #Genero otra condición if para asegurarme que no ingrese valores negativos en la base o la altura, ya que esto no es 
            #posible.
            if(base and altura >= 0):
                #Realizo el cálculo del perímetro para luego mostrarlo en pantalla.
                perimetro = (2*base)+(2*altura)
                print("\n")
                print('El perímetro del rectángulo',i+1,'es',perimetro)
            else:
                print('Los valores ingresados no existen, intente nuevamente')
    else:
        print('Ingrese un valor correcto, recuerde que debe haber mínimo un rectángulo')

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    num_rectangulos = leerVariables()
    calculadorPerimetro(num_rectangulos)