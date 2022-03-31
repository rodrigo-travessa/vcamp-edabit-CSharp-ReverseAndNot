# vcamp-edabit-CSharp-ReverseAndNot

Rodrigo Abdo Feres Sigiliao Travessa

Linkedin https://www.linkedin.com/in/rodrigotravessa/

Captura do Teste:

![Resposta Edabit](https://user-images.githubusercontent.com/90840099/161109057-165a9e66-f01b-4eba-bf00-5868be1b11f8.PNG)

https://edabit.com/challenge/YGhgctqPsKQxQQCFS

O desafio consistia em receber uma int Ex: 123, invertê-la Ex: 321,  e adicionar ao final a int original Ex: 321123, retornando em forma de String.

Haviam algumas maneiras de fazê-lo mas optei pela maneira mais sucinta que encontrei.

Usando String.Join("[separador]", [array/lista]) podemos fornecer um separador no caso uma string vazia (""), e um array, pra criar o array, primeiro transformei a INT que o problema nos traz em string, e depois usei o método .Reverse() que aceita a int convertida em string, e devolve um array de chars, esse array será utilizado pelo método Join e terá todos os elementos concatenados usando um separador vazio, criando assim a string invertida.

Após termos a string invertida, basta adicionar ao fim dela o int original, também convertido pra string.

return String.Join("", i.ToString().Reverse()) + i.ToString();
