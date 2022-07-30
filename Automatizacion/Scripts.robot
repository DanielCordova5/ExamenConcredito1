*** Settings ***
Resource    Resources.robot

*** Test Cases ***
G001 Busqueda y validación de cambio de página
    Abrir navegador y esperar
    Input Text      xpath=//input[@class='gLFyf gsfi' and @name ='q']   ${word1}
    Click Element   xpath=//img[@class ='lnXdpd' and @alt ='Google']
    Click Element   xpath=(//input[@role="button"])[2]
    Page Should Contain     ${word1}
    Close Browser

G002 Busqueda con boton me siento con suerte
    Abrir navegador y esperar
    Input Text      xpath=//input[@class='gLFyf gsfi' and @name ='q']   ${word1}
    Click Element   xpath=//img[@class ='lnXdpd' and @alt ='Google']
    Click Element   xpath=(//input[@role="button"])[2]
    Page Should Contain     ${word1}
    Close Browser

G003 Realizar una búsqueda y después otra búsqueda
    Abrir navegador y esperar
    Input Text      xpath=//input[@class='gLFyf gsfi' and @name ='q']   ${word1}
    Click Element   xpath=//img[@class ='lnXdpd' and @alt ='Google']
    Click Element   xpath=(//input[@role="button"])[2]
    Page Should Contain     ${word1}
    Input Text      xpath=//input[@role='combobox']     ${word2}
    Wait Until Element Is Visible   xpath=(//input[@role='combobox'])[1]
    Click Element   xpath=(//button)[1]
    Page Should Contain     ${word2}
    Close Browser

G004 Realizar una búsqueda, cambiar de página de resultados y validar
    Abrir navegador y esperar
    Input Text      xpath=//input[@class='gLFyf gsfi' and @name ='q']   ${word1}
    Click Element   xpath=//img[@class ='lnXdpd' and @alt ='Google']
    Click Element   xpath=(//input[@role="button"])[2]
    Page Should Contain     ${word1}
    Click Element   xpath=//a[@aria-label='Page 2']
    Page Should Contain     Página 2
    Close Browser

G005 Realizar una búsqueda, abrir una imagen, validar que la muestre, cerrar y validar que cierre
    Abrir navegador y esperar
    Click Element   xpath=(//a[@class="gb_d"])[2]
    Input Text      xpath=//input[@title='Buscar' and @role='combobox']     ${word1}
    Click Element   xpath=//img[@alt="Imágenes de Google"]
    Click Element   xpath=//button[@type="submit"]
    Wait Until Element Is Visible   xpath=//img[@alt="ConCrédito - Esto es Culiacán"]
    Click Element   xpath=//img[@alt="ConCrédito - Esto es Culiacán"]
    Wait Until Element Is Visible   xpath=//div[@id="Sva75c"]
    Click Element   xpath=(//a[@role="button"])[3]
    Wait Until Element Is Not Visible   xpath=//div[@id="Sva75c"]
    Close Browser