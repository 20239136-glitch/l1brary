namespace l1brary.Models;

public class MemberDetails
{
    public Member Member { get; set; } = new();
    public List<LoanView> Loans { get; set; } = new();
}
