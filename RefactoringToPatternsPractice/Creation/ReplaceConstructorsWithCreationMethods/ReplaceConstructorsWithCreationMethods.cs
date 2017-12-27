using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToPatternsPractice.Creation.ReplaceConstructorsWithCreationMethods
{
    public class ReplaceConstructorsWithCreationMethods
    {
        public void Sample()
        {
            var commitment = 0.00;
            var riskRating = 0;
            DateTime maturity = new DateTime();
            Loan termLoan = Loan.CreateTermLoan(commitment, riskRating, maturity);

            var riskAdjustedCapitalStrategy = new CapitalStrategy();
            var outstanding = 0.0;
            Loan termLoan2 = Loan.CreateTermLoan(
                riskAdjustedCapitalStrategy,
                commitment,
                outstanding,
                riskRating,
                maturity,
                null);

            Loan revolver = Loan.CreateRevolver(commitment, outstanding, riskRating, maturity, null);
        }

        public class Loan
        {
            private double _commitment;

            private double _outstanding;

            private int _riskRating;

            private DateTime _maturity;

            private DateTime _expiry;

            private CapitalStrategy _capitalStrategy;

            public Loan(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating, DateTime? maturity, DateTime? expiry)
            {
                this._commitment = commitment;
                this._outstanding = outstanding;
                this._riskRating = riskRating;
                this._maturity = maturity.Value;
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

            public static Loan CreateTermLoan(double commitment, int riskRating, DateTime maturity)
            {
                return new Loan(null, commitment, 0.00, riskRating, maturity, null);
            }

            public static Loan CreateTermLoan(CapitalStrategy riskAdjustedCapitalStrategy, double commitment, double outstanding, int riskRating, DateTime maturity, DateTime? expiry)
            {
                return new Loan(riskAdjustedCapitalStrategy, commitment, outstanding, riskRating, maturity, null);
            }

            public static Loan CreateRevolver(
                double commitment,
                double outstanding,
                int riskRating,
                DateTime maturity,
                DateTime? expiry)
            {
                return new Loan(null, commitment, outstanding, riskRating, maturity, expiry);
            }

            public static Loan CreateRevolver(
                CapitalStrategy riskAdjustedCapitalStrategy,
                double commitment,
                double outstanding,
                int riskRating,
                DateTime? expiry)
            {
                return new Loan(riskAdjustedCapitalStrategy, commitment, outstanding, riskRating, null, expiry);
            }

            public static Loan CreateRCTL(
                double commitment,
                double outstanding,
                int riskRating,
                DateTime maturity,
                DateTime expiry)
            {
                return new Loan(null, commitment, outstanding, riskRating, maturity, expiry);
            }

            public static Loan CreateRCTL(
                CapitalStrategy riskAdjustedCapitalStrategy,
                double outstanding,
                int riskRating,
                DateTime maturity,
                DateTime expiry)
            {
                return new Loan(riskAdjustedCapitalStrategy, outstanding, outstanding, riskRating, maturity, expiry);
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
}