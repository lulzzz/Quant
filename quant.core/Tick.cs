﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("quant.rx")]
namespace quant.core
{
    public enum Aggressor { NA, Buy, Sell }

    /// <summary>
    /// don't want anyone to derive from it (especially Tick)
    /// 
    /// </summary>
    public sealed class QTY_PX
    {
        public uint QTY { get; internal set; }
        public double PX { get; internal set; }
        public double PxVol => PX * QTY;
        public QTY_PX(uint qty, double price) { QTY = qty; PX = price; }
    }
    /// <summary>
    /// represents tick data of a given Security
    /// </summary>
    public class Tick
    {
        #region ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sec"></param>
        /// <param name="qty"></param>
        /// <param name="price">in qep format</param>
        /// <param name="atTS"></param>
        public Tick(Security sec, uint qty, uint price, DateTime atTS) {
            Security = sec;
            Quantity = qty;
            Price = price;
            TradedAt = atTS;
        }
        #endregion
        #region properties
        public Security     Security    { get; }
        public uint         Quantity    { get; }
        public uint         Price       { get; }
        public DateTime     TradedAt    { get; }
        public Aggressor    Side        { get; set; } = Aggressor.NA;
        public bool         Live        { get; set; } = false;
        public double       PxVol => Price * Quantity;
        #endregion

        #region Object
        public override string ToString() {
            var tm = TradedAt.ToString("MM/dd/yyyy HH:mm:ss.fff");
            return $"[{Security}\t{tm}\t{Quantity.ToString("N0").PadLeft(3)}\t{Price}]";
        }
        #endregion
    }
}
