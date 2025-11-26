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

        var skillsRaw = (entrySkills?.Text ?? string.Empty).Trim();
        var experienciasRaw = (editorExperiencias?.Text ?? string.Empty).Trim();

        // Template solicitado, com placeholder {nome}
        var template = @"
Resumo profissional:
Sou {nome}, um profissional comprometido, responsável e orientado a resultados. Possuo facilidade para aprender, adaptar-me a novas demandas e atuar de forma colaborativa com diferentes equipes. Prezo pela organização, comunicação eficiente e postura profissional em todas as atividades desempenhadas. Busco uma oportunidade que permita aplicar minhas competências, desenvolver novos conhecimentos e contribuir de maneira consistente para o crescimento da empresa.

Habilidades:
{habilidades}

Experiências anteriores:
{experiencias}
";

        // Formata habilidades (cada item em uma linha com "- ")
        var habilidadesFormatted = "Nenhuma habilidade informada.";
        if (!string.IsNullOrWhiteSpace(skillsRaw))
        {
            var parts = skillsRaw.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
                parts[i] = "- " + parts[i].Trim();
            habilidadesFormatted = string.Join(Environment.NewLine, parts);
        }

        var experienciasFormatted = string.IsNullOrWhiteSpace(experienciasRaw)
            ? "Nenhuma experiência anterior informada."
            : experienciasRaw.Trim();

        var curriculo = template
            .Replace("{nome}", nome)
            .Replace("{habilidades}", habilidadesFormatted)
            .Replace("{experiencias}", experienciasFormatted)
            .Trim();

        editorCurriculo.Text = curriculo;
    }

    void OnLimparClicked(object sender, EventArgs e)
    {
        entryNome.Text = string.Empty;
        entrySkills.Text = string.Empty;
        editorExperiencias.Text = string.Empty;
        editorCurriculo.Text = string.Empty;
    }
}