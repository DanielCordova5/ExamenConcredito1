palabra1 = 'casa'
palabra2 = 'Casa'
resultado = False



def comparacion(palabra1, palabra2):
    palabra1 = palabra1.lower()
    palabra2 = palabra2.lower()

    if palabra1 != palabra2:
        listaPalabra1 = list(palabra1)
        listaPalabra2 = list(palabra2)

        if(len(listaPalabra1) == len(listaPalabra2)):
            listaPalabra1.sort()
            listaPalabra2.sort()

            if(listaPalabra1 == listaPalabra2):
                return print("Si es un anagrama")
            else:
                return print("No es un anagrama")

        else:
            return print("No es un anagrama")
    else:
        return print("Es la misma palabra")

comparacion(palabra1, palabra2)

