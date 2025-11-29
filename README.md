 Conversor de Temperaturas
🎯 Objetivo
Este programa é um conversor de temperaturas que transforma valores digitados em Celsius para as escalas Kelvin e Fahrenheit.

⚙️ Funcionalidades
Entrada de Dados
Solicita ao usuário que digite uma temperatura em graus Celsius

Captura o valor digitado via console

Processamento
Validação da Entrada

Verifica se o valor digitado é um número válido

Usa double.TryParse() para conversão segura

Conversões Realizadas

Celsius → Kelvin: K = °C + 273.15

Celsius → Fahrenheit: °F = (°C × 9/5) + 32

Saída de Resultados
Exibe as temperaturas convertidas formatadas com 2 casas decimais

Mostra unidades de medida apropriadas (K para Kelvin, °F para Fahrenheit)

🛡️ Tratamento de Erros
Captura exceções genéricas com bloco try-catch

Valida entrada inválida com mensagem amigável

Previne falhas por digitação incorreta


<img width="998" height="553" alt="image" src="https://github.com/user-attachments/assets/9bd97dff-7407-492a-b0e4-5db7bde82060" />
<img width="1213" height="552" alt="image" src="https://github.com/user-attachments/assets/8b319aaf-5470-4f7a-ba16-1da8a7e8c9db" />




🏗️ Estrutura do Código
Namespace: TemperatureConverter

Classe Principal: Program

Método Principal: Main com tratamento de erros

Variáveis: celsius, kelvin, fahrenheit (tipos double)

💡 Características Técnicas
Desenvolvido em C#

Usa interpolação de strings para formatação

Aplicação console-based

Robusto contra entradas inválidas

Precisão com valores decimais

Este programa é útil para fins educacionais, cálculos rápidos ou como base para sistemas mais complexos de conversão de unidades.
