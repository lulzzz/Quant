﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("quant.core.test")]
namespace quant.core
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Relative Strength
    // RS = Average Gain / Average Loss
    // AverageGain  = WSMA of Gain(Period)  ?? or SMA of Gain/Loss(Period)
    // AverageLoss = WSMA of Loss(Period)
    // http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:relative_strength_index_rsi
    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    internal class RS
    {
        WSMA gain;
        WSMA loss;
        public uint Period => gain.Period;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="period"></param>
        public RS(uint period) {
            gain = new WSMA(period);
            loss = new WSMA(period);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public double Calc(double val) {
            //edge condition
            if (double.IsNaN(val))
                return double.NaN;

            double avg_gain = (val > 0) ? gain.Calc(val) : gain.Calc(0);
            double avg_loss = (val < 0) ? loss.Calc(Math.Abs(val)) : loss.Calc(0);
            return (avg_loss == 0) ? 100 : (avg_gain / avg_loss);
        }
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Relative Strength Indicator (RSI)
    // RSI is a momentum oscillator that measures the speed and change of price movements. RSI oscillates between zero and 100. 
    // RSI is considered overbought when above 70 and oversold when below 30. 
    // Signals can also be generated by looking for divergences, failure swings, and centerline crossovers. 
    // RSI can also be used to identify the general trend
    //
    //RSI work best when prices move sideways within a range
    //
    // RSI = 100 - (100/(1 + RS)) 
    // http://stockcharts.com/school/doku.php?id=chart_school:technical_indicators:relative_strength_index_rsi
    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class RSI
    {
        double _prev = double.NaN;
        RS _rs;
        /// <summary>
        /// 
        /// </summary>
        public uint Period => _rs.Period;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="period"></param>
        public RSI(uint period) {
            _rs = new RS(period);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newVal"></param>
        /// <returns></returns>
        public double Calc(double newVal) {
            // initial return to store 1st value
            if (double.IsNaN(_prev)) {
                _prev = newVal;
                return double.NaN;
            }
            // we have a valid prev value
            double diff = newVal - _prev;
            _prev = newVal;
            return 100 - (100 / (1 + _rs.Calc(diff)));
        }
    }
}
