# Resumo do Projeto: Sistema de Conversão
Este projeto é um aplicativo .NET MAUI chamado "Sistema de Conversão", desenvolvido para converter unidades de medida entre diferentes escalas. O aplicativo possui várias páginas dedicadas a diferentes tipos de conversões e uma página "Sobre" que fornece informações sobre o aplicativo.

## Estrutura do Projeto

1.	App.xaml e App.xaml.cs <br>
      ·	Define a aplicação e inicializa o AppShell como a página principal.<br>
2.	AppShell.xaml e AppShell.xaml.cs <br>
      ·	Configura a navegação do aplicativo usando o Shell.<br>
      ·	Inclui itens de menu para navegar entre as diferentes páginas de conversão e a página "Sobre".<br>
3.	HomePage.xaml e HomePage.xaml.cs <br>
      ·	Página inicial do aplicativo.<br>
      ·	Contém um título "DESENVOLVIMENTO MOBILE ANDROID" e botões para navegar para as páginas de conversão e a página "Sobre".<br>
      ·	Os botões estão posicionados na parte inferior da tela, lado a lado, com espaçamento entre eles.<br>
4.	KilometrosParaMetros.xaml e KilometrosParaMetros.xaml.cs <br>
      ·	Página para converter Kilômetros para Metros.<br>
      ·	Contém um campo de entrada para o valor em Kilômetros e um botão para realizar a conversão.<br>
      ·	Exibe o resultado da conversão.<br>
5.	HectometrosParaMetros.xaml e HectometrosParaMetros.xaml.cs <br>
      ·	Página para converter Hectômetros para Metros.<br>
      ·	Similar à página de Kilômetros para Metros, mas para Hectômetros.<br>
6.	MetrosParaCentimetros.xaml e MetrosParaCentimetros.xaml.cs <br>
      ·	Página para converter Metros para Centímetros.<br>
      ·	Similar às outras páginas de conversão, mas para Metros.<br>
7.	Sobre.xaml e Sobre.xaml.cs <br>
      ·	Página "Sobre" que fornece informações sobre o aplicativo.<br>
      ·	Contém texto explicativo sobre o propósito do aplicativo e o desenvolvedor.<br>
      ·	Inclui um efeito de sombra nos textos para um destaque visual.<br>



## Navegação

A navegação entre as páginas é gerenciada pelo AppShell.xaml, que define os itens do menu de navegação. Cada item do menu redireciona para uma das páginas de conversão ou para a página "Sobre".


## Funcionalidade

·	<b>Conversão de Unidades</b>: Cada página de conversão permite ao usuário inserir um valor em uma unidade específica e convertê-lo para outra unidade. O resultado é exibido na mesma página. <br>
·	<b>Página Sobre:</b> Fornece informações sobre o aplicativo e o desenvolvedor, com um efeito visual especial nos textos.

# Código de Exemplo
## HomePage.xaml
```
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DesignerMobile.Pages.HomePage"
             Title="Sistema de Conversão">
    <Grid Padding="10">
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>

        <Label Text="DESENVOLVIMENTO MOBILE ANDROID" FontSize="Large" HorizontalOptions="Center" VerticalOptions="Center" Grid.Row="0" />

        <HorizontalStackLayout HorizontalOptions="Center" Spacing="10" Grid.Row="1">
            <Button Text="KM -> MT" Clicked="OnKmToMtClicked" BackgroundColor="Black" FontSize="Micro"/>
            <Button Text="MT -> CM" Clicked="OnMtToCmClicked" BackgroundColor="Black" FontSize="Micro" />
            <Button Text="HEC -> MT" Clicked="OnHecToMtClicked" BackgroundColor="Black" FontSize="Micro" />
            <Button Text="SOBRE" Clicked="OnSobreClicked" BackgroundColor="Black" FontSize="Micro"/>
        </HorizontalStackLayout>
    </Grid>
</ContentPage>
```



## Sobre.xaml
```

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="DesignerMobile.Pages.Sobre"
             Title="Sobre">
    <StackLayout Padding="10">
        <Label Text="Sobre o Sistema de Conversão" FontSize="Large" Margin="0,0,0,10" />
        <Label Text="Este aplicativo permite converter unidades de medida entre Kilômetros, Hectômetros, Metros e Centímetros." FontSize="Medium" Margin="0,0,0,10">
            <Label.Shadow>
                <Shadow Brush="Black" Offset="2,2" Opacity="0.8" />
            </Label.Shadow>
        </Label>
        <Label Text="Desenvolvido por 2405536 - Isaias Neri da Conceição Junior" FontSize="Medium">
            <Label.Shadow>
                <Shadow Brush="Black" Offset="2,2" Opacity="0.8" />
            </Label.Shadow>
        </Label>
    </StackLayout>
</ContentPage>
```

### Home
![image](https://github.com/user-attachments/assets/bc33ddff-d0cf-4767-89cc-7fd8e27d11dc)

### Kilômetros para Metros

![image](https://github.com/user-attachments/assets/b6c43739-407a-4ffa-88c9-425d75c5a1a2)

### Metros para Centimetros 

![image](https://github.com/user-attachments/assets/64acd977-4cfd-4e3d-838b-083d92ca5686)

### Hectômetros para Metros

![image](https://github.com/user-attachments/assets/939b8c43-0a04-4938-bfe2-9ab42628a42b)


### Sobre

![image](https://github.com/user-attachments/assets/9c27f7db-a9c2-466e-b9bf-412cf1909fee)




#### OBS: Este é um trabalho feito na faculdade, por solicitação do professor, não foi pensado em melhorias ou atribuições a mais que poderiamos implementar, foi feito conforme solicitado para atender a necessidade da atividade.



  






