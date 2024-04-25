public static class TypeBroker
{
    static IResponseFormatter formatter = new TextResponseFormatter();
    public static IResponseFormatter Formatter => formatter;
}