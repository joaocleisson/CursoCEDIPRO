namespace exercicio1;
using System;

public class Retangulo
{
    // Atributos da classe. Estão com underline porque são privados
    private double _base;
    private double _altura;

    // Construtor padrão. Solicitando entrar com valor para base e altura
    public Retangulo(double baseRetangulo, double alturaRetangulo)
    {
        _base = baseRetangulo;
        _altura = alturaRetangulo;
    }

    // Método para alterar os valores dos lados
    public void AlterarLados(double novaBase, double novaAltura)
    {
        _base = novaBase;
        _altura = novaAltura;
    }

    // Métodos para retornar os valores dos lados
    public double RetornarBaseAltura()
    {
        return _base + _altura;
    }
    

    // Método para calcular a área
    public double CalcularArea()
    {
        return _base * _altura;
    }

    // Método para calcular o perímetro
    public double CalcularPerimetro()
    {
        return 2 * (_base + _altura);
    }
}