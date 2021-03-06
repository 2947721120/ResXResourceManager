﻿namespace tomenglertde.ResXManager.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    using JetBrains.Annotations;

    [ContractClass(typeof (TranslationItemContract))]
    public interface ITranslationItem
    {
        [NotNull]
        string Source
        {
            get;
        }

        [NotNull]
        IList<ITranslationMatch> Results
        {
            get;
        }

        [NotNull]
        CultureKey TargetCulture
        {
            get;
        }
    }

    [ContractClassFor(typeof (ITranslationItem))]
    internal abstract class TranslationItemContract : ITranslationItem
    {
        string ITranslationItem.Source
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                throw new NotImplementedException();
            }
        }

        IList<ITranslationMatch> ITranslationItem.Results
        {
            get
            {
                Contract.Ensures(Contract.Result<IList<ITranslationMatch>>() != null);
                throw new NotImplementedException();
            }
        }

        public CultureKey TargetCulture
        {
            get
            {
                Contract.Ensures(Contract.Result<CultureKey>() != null);
                throw new NotImplementedException();
            }
        }
    }
}