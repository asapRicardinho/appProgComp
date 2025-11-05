using System;
using Microsoft.Maui.Controls;

namespace appProgComp.Views;

public partial class montarCurriculo : ContentPage
{
    public montarCurriculo()
    {
        InitializeComponent();
    }

    async void OnGerarClicked(object sender, EventArgs e)
    {
        var nome = (entryNome?.Text ?? string.Empty).Trim();

        if (string.IsNullOrWhiteSpace(nome))
        {
            await DisplayAlert("Nome obrigatório", "Por favor, informe seu nome.", "OK");
            return;
        }

        // Gera um texto simples de currículo; ajuste conforme necessário.
        var curriculo = $@"
{nome}
Resumo profissional:
Profissional iniciante motivado, com boa capacidade de aprendizado e interesse em iniciar a carreira na área técnica. Procuro oportunidades para aplicar conhecimentos práticos e desenvolver habilidades profissionais.

Objetivo:
Busco posição de nível júnior ou estágio onde eu possa contribuir com minha dedicação, aprender com equipes experientes e crescer profissionalmente.

Principais competências:
- Boa comunicação e trabalho em equipe.
- Interesse em aprender novas tecnologias e ferramentas.
- Proatividade e responsabilidade.

Formação:
- Ensino médio completo / em andamento (adicione sua formação real).

Experiência:
- (Se for inicial, descreva estágios, trabalhos temporários ou projetos estudantis relevantes.)

Observações finais:
Disponibilidade para entrevistas e início conforme combinado. Contato disponível no currículo anexo.

";

        // Substituições simples para personalizar mais o texto
        curriculo = curriculo.Replace("Profissional iniciante", "Profissional iniciante: " + nome.Split(' ')[0]);

        editorCurriculo.Text = curriculo.Trim();
    }

    void OnLimparClicked(object sender, EventArgs e)
    {
        entryNome.Text = string.Empty;
        editorCurriculo.Text = string.Empty;
    }
}