namespace NationalIdVerification.Binary
{
    public class Node
    {
        public int Value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    } 
}
