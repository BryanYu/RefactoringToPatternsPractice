using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToPatternsPractice.Creation.ReplaceConstructorsWithCreationMethods
{
    public class ReplaceConstructorsWithCreationMethods
    {
        public class Loan
        {
            private double _commitment;

            private double _outstanding;

            private int _riskRating;

            private DateTime _maturity;

            private DateTime _expiry;

            private CapitalStrategy _capitalStrategy;

            public Loan(double commitment, int riskRating, DateTime maturity) : this(commitment, 0.00, riskRating, maturity, null)
            {
            }

            public Loan(double commitment, int riskRating, DateTime maturity, DateTime expiry) : this(commitment, 0.00, riskRating, maturity, expiry)
            {
            }

            public Loan(double commitment, double outstanding, int riskRating, DateTime maturity, DateTime? expiry) : this(null, commitment, outstanding, riskRating, maturity, expiry)
            {
            }

            public Loan(CapitalStrategy capitalStrategy, double commitment, int riskRating, DateTime maturity, DateTime? expiry) : this(capitalStrategy, commitment, 0.00, riskRating, maturity, expiry)
            {
            }

            public Loan(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating, DateTime maturity, DateTime? expiry)
            {
                this._commitment = commitment;
                this._outstanding = outstanding;
                this._riskRating = riskRating;
                this._maturity = maturity;
                this._expiry = expiry.Value;
                this._capitalStrategy = capitalStrategy;
                if (capitalStrategy == null)
                {
                    if (expiry == null)
                    {
                        this._capitalStrategy = new CapitalStrategyTermLoan();
                    }
                    else if (maturity == null)
                    {
                        this._capitalStrategy = new CapitalStrategyRevolver();
                    }
                    else
                    {
                        this._capitalStrategy = new CapitalStrategyRCTL();
                    }
                }
            }
        }
    }

    public class CapitalStrategyRCTL : CapitalStrategy
    {
    }

    public class CapitalStrategyRevolver : CapitalStrategy
    {
    }

    public class CapitalStrategyTermLoan : CapitalStrategy
    {
    }

    public class CapitalStrategy
    {
    }
}