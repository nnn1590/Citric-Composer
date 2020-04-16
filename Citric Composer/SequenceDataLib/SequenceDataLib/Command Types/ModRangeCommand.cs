﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceDataLib {

    /// <summary>
    /// Mod range command.
    /// </summary>
    public class ModRangeCommand : SequenceCommand {

        /// <summary>
        /// Set defauls.
        /// </summary>
        public ModRangeCommand() {

            //Set identifier.
            Identifier = (byte)CommandType.ModRange;

            //Parameter types.
            SequenceParameterTypes = new List<SequenceParameterType>() { SequenceParameterType.s8 };

            //Set parameters.
            Parameters = new object[SequenceParameterTypes.Count];

            //Set thing.
            Range = 1;

        }

        /// <summary>
        /// Range.
        /// </summary>
        public sbyte Range {
            get { return (sbyte)Parameters[0]; }
            set { Parameters[0] = value; }
        }

    }

}