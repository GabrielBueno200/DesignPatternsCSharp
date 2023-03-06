namespace Example;

public class CodeBuilder
{
    private Code rootCode;

    public CodeBuilder(string className)
    {
        rootCode = new Code(className);
    }

    public CodeBuilder AddField(string fieldName, string fieldType)
    {
        rootCode.Fields.Add(new Code(fieldName, fieldType));
        return this;
    }

    public override string ToString()
    {
        return rootCode.ToString();
    }
}