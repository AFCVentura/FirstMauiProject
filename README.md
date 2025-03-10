O alerta simples pode ser feito com o método ``await DisplayAlert(titulo, texto, opcao)``. Esse tipo de alerta não retorna nada baseado na interação do usuário.
```c#
await DisplayAlert("Alerta", "Você foi alertado", "OK");
```


Para dar duas opções para o usuário e capturar qual ele selecionou basta adicionar mais um parâmetro no mesmo método que representa a segunda opção (falsa), essa sobrecarga do método retorna um booleano.
```c#
await DisplayAlert("Alerta", "Você foi alertado?", "Sim", "Não);
```

Para dar várias opções no formato de lista dentro do alerta para o usuário e capturar qual ele escolheu, use o método ``DisplayActionSheet()``
```c#
// A parte das opções pode ter mais
string action = await DisplayActionSheet("Escolha uma opção", "Botão de Cancelar", "Segundo Botão", "Primeira opção", "Segunda opção", "Terceira opção");
```
  
Para permitir que o usuário escreva o que quiser num prompt, use o método ``await DisplayPromptAsync("Titulo", "Texto");``
