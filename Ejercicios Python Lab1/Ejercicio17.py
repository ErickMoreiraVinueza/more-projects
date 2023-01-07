def muestraTipoDato():
    """"
    Se crea la función para mostrar el tipo de dato que haya digitado el usuario.
    .
  
    Parámetros:
    -------------------
    No recibe ningún parámetro.

    Retorna:
    -------------------
    No retorna ningún valor.
    """
    #Almaceno el dato.
    print('\nIngrese el dato que desea saber su tipo:')
    dato = input()
    #Ingreso el dato establecido por usuario en el metodo type para saber su tipo.
    tipo_dato = type(dato)
    print("El tipo de dato que ingresó es",tipo_dato)

#if main de nuestro programa dónde solo ejecuto la función correspondiente.
if __name__ == '__main__':
    muestraTipoDato()
