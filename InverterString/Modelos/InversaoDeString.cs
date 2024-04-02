namespace InverterString.Modelos;

internal class InversaoDeString
{
    public string InverseString { get; set; } = "";

    public string InvertString(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            InverseString += str[i];
        }

        return InverseString;
    }
}
