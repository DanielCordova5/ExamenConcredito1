*** Settings ***
Documentation       Los pasos están en el manual de examen de concredito.
...                 Punto d.
Library             SeleniumLibrary

*** Variables ***
${URL}      https://www.google.com/
${nav}      chrome
${word1}    concredito
${word2}    asgaror

*** Keywords ***
Abrir navegador y esperar
    Open Browser    ${URL}     ${nav}
    Maximize Browser Window
    Wait Until Element Is Visible   xpath=//img[@class ='lnXdpd' and @alt ='Google']