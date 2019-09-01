﻿namespace LuKaSo.Zonky.Models.Investments
{
    public enum InvestmentEventBusinessCode
    {
        LC_OTHER,
        LC_CREDIT_REDEMPTION,
        LC_CREDIT_REDEMPTION_CALL,
        LC_INSOLVENCY_PROCEEDINGS_INITIATION,
        LC_ALLOWED_DEBT_CREDIT_REDEMPTION,
        LC_LO_SENDS_PRELIGITATION,
        LC_JUDICAL_ENFORCEMENT_INITIATION,
        LC_REPAYMEND_SCHEDULE_APPROVING,
        LC_FILED_CRIMINAL_NOTICE,
        LC_INHERITANCE_APPLICATION_SUBMISSION,
        LC_ZONKY_SENDS_PRETRIAL,
        LC_EXECUTION_LAUNCH,
        LC_PARTIAL_SATISFACTION_OF_CLAIM_IN_THE_INHERITANCE,

        AUTO_LOAN_OVERDUE_INST_3RD_PENALTY_WARNING,
        AUTO_LOAN_OVERDUE_INST_DEFAULT_WARNING,
        AUTO_LOAN_OVERDUE_INST_3RD_INST_APROACHING,
        AUTO_LOAN_OVERDUE_INST_AFTER_2ND_PENALTY_WARNING,
        AUTO_LOAN_OVERDUE_INST_2ND_PENALTY_WARNING,
        AUTO_LOAN_OVERDUE_INST_JUDICIAL_ENFORCMENT_WARNING,
        AUTO_LOAN_OVERDUE_INST_2ND_INST_APROACHING,
        AUTO_LOAN_OVERDUE_INST_PENALTY_WARNING,
        AUTO_LOAN_OVERDUE_INSURANCE_TERMINATION_WARN,

        AUTO_LOAN_DELAY_BORROWER,
        AUTO_BORROWER_RECOVERED,
        AUTO_PAYMENT_PAIRED,
        AUTO_PAYMENT_BLOCKED,

        EC_SUCCESS_BY_CLIENT,
        EC_SUCCESS_BY_ZONKY,
        EC_UNSUCCESS_BY_ZONKY,
        EC_NOTE
    }
}
