﻿using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using quant.core;

namespace quant.rx.test
{
    /// <summary>
    /// Data from Excel
    /// https://chartpatterns.files.wordpress.com/2011/11/excel-indicators.xls
    /// </summary>
    public struct BarData
    {
        public DateTime Date { get; }
        public double Open { get; }
        public double High { get; }
        public double Low { get; }
        public double Close { get; }
        public BarData(string dt, double op, double hi, double lo, double cl)
        {
            Date = DateTime.Parse(dt);
            Open = op;
            High = hi;
            Low = lo;
            Close = cl;
        }
        /// <summary>
        /// data from excel document on desktop
        /// </summary>
        public static IList<BarData> DATA
        {
            get
            {
                return new BarData[] {
                    new BarData("1/3/2011",11577.43,11711.47,11577.35,11670.75),
                    new BarData("1/4/2011",11670.90,11698.22,11635.74,11691.18),
                    new BarData("1/5/2011",11688.61,11742.68,11652.89,11722.89),
                    new BarData("1/6/2011",11716.93,11736.74,11667.46,11697.31),
                    new BarData("1/7/2011",11696.86,11726.94,11599.68,11674.76),
                    new BarData("1/10/2011",11672.34,11677.33,11573.87,11637.45),
                    new BarData("1/11/2011",11638.51,11704.12,11635.48,11671.88),
                    new BarData("1/12/2011",11673.62,11782.23,11673.62,11755.44),
                    new BarData("1/13/2011",11753.70,11757.25,11700.53,11731.90),
                    new BarData("1/14/2011",11732.13,11794.15,11698.83,11787.38),
                    new BarData("1/18/2011",11783.82,11858.78,11777.99,11837.93),
                    new BarData("1/19/2011",11834.21,11861.24,11798.46,11825.29),
                    new BarData("1/20/2011",11823.70,11845.16,11744.77,11822.80),
                    new BarData("1/21/2011",11822.95,11905.48,11822.80,11871.84),
                    new BarData("1/24/2011",11873.43,11982.94,11867.98,11980.52),
                    new BarData("1/25/2011",11980.52,11985.97,11898.74,11977.19),
                    new BarData("1/26/2011",11978.85,12020.52,11961.83,11985.44),
                    new BarData("1/27/2011",11985.36,12019.53,11971.93,11989.83),
                    new BarData("1/31/2011",11824.39,11891.93,11817.88,11891.93),
                    new BarData("2/1/2011",11892.50,12050.75,11892.50,12040.16),
                    new BarData("2/2/2011",12038.27,12057.91,12018.51,12041.97),
                    new BarData("2/3/2011",12040.68,12080.54,11981.05,12062.26),
                    new BarData("2/4/2011",12061.73,12092.42,12025.78,12092.15),
                    new BarData("2/7/2011",12092.38,12188.76,12092.30,12161.63),
                    new BarData("2/8/2011",12152.70,12238.79,12150.05,12233.15),
                    new BarData("2/9/2011",12229.29,12254.23,12188.19,12239.89),
                    new BarData("2/10/2011",12239.66,12239.66,12156.94,12229.29),
                    new BarData("2/11/2011",12227.78,12285.94,12180.48,12273.26),
                    new BarData("2/14/2011",12266.83,12276.21,12235.91,12268.19),
                    new BarData("2/15/2011",12266.75,12267.66,12193.27,12226.64),
                    new BarData("2/16/2011",12219.79,12303.16,12219.79,12288.17),
                    new BarData("2/17/2011",12287.72,12331.31,12253.24,12318.14),
                    new BarData("2/22/2011",12389.74,12389.82,12176.31,12212.79),
                    new BarData("2/23/2011",12211.81,12221.12,12063.43,12105.78),
                    new BarData("2/24/2011",12104.56,12129.62,11983.17,12068.50),
                    new BarData("2/25/2011",12060.93,12151.03,12060.93,12130.45),
                    new BarData("2/28/2011",12130.45,12235.04,12130.15,12226.34),
                    new BarData("3/1/2011",12226.49,12261.38,12054.99,12058.02),
                    new BarData("3/2/2011",12057.34,12115.12,12018.63,12066.80),
                    new BarData("3/3/2011",12068.01,12283.10,12068.01,12258.20),
                    new BarData("3/7/2011",12171.09,12243.44,12041.60,12090.03),
                    new BarData("3/8/2011",12085.87,12251.20,12072.21,12214.38),
                    new BarData("3/9/2011",12211.16,12257.82,12156.60,12213.09),
                    new BarData("3/10/2011",12211.43,12211.43,11974.39,12023.89),
                    new BarData("3/11/2011",11976.96,12087.01,11936.32,12044.40),
                    new BarData("3/14/2011",12042.13,12042.13,11897.31,11993.16),
                    new BarData("3/15/2011",11988.69,11988.69,11696.25,11891.21),
                    new BarData("3/16/2011",11854.20,11856.70,11555.48,11613.30),
                    new BarData("3/17/2011",11614.89,11800.54,11614.82,11774.59),
                    new BarData("3/18/2011",11777.23,11927.09,11777.23,11858.52),
                    new BarData("3/21/2011",11860.11,12078.30,11860.11,12036.53),
                    new BarData("3/22/2011",12036.37,12050.98,12002.85,12018.63),
                    new BarData("3/23/2011",12018.40,12116.14,11972.61,12086.02),
                    new BarData("3/24/2011",12087.54,12191.18,12087.54,12170.56),
                    new BarData("3/25/2011",12170.71,12259.79,12170.71,12220.59),
                    new BarData("3/28/2011",12221.19,12272.92,12197.88,12197.88),
                    new BarData("3/29/2011",12194.48,12285.41,12173.51,12279.01),
                    new BarData("3/30/2011",12280.07,12383.46,12280.07,12350.61),
                    new BarData("3/31/2011",12350.76,12381.68,12319.01,12319.73),
                    new BarData("4/1/2011",12321.02,12419.71,12321.02,12376.72),
                    new BarData("4/4/2011",12374.60,12407.41,12369.15,12400.03),
                    new BarData("4/5/2011",12402.08,12438.14,12353.34,12393.90),
                    new BarData("4/6/2011",12386.66,12450.93,12386.66,12426.75),
                    new BarData("4/7/2011",12426.45,12440.56,12328.36,12409.49),
                    new BarData("6/13/2011",11945.33,12011.66,11917.78,11952.97),
                    new BarData("6/14/2011",11951.38,12120.80,11951.38,12076.11),
                    new BarData("6/15/2011",12075.12,12075.20,11862.53,11897.27),
                    new BarData("6/16/2011",11896.13,11990.02,11875.77,11961.52),
                    new BarData("6/17/2011",11962.66,12072.89,11962.51,12004.36),
                    new BarData("6/21/2011",12081.33,12217.33,12081.18,12190.01),
                    new BarData("6/22/2011",12189.71,12207.99,12105.85,12109.67),
                    new BarData("6/23/2011",12108.35,12108.73,11874.94,12050.00),
                    new BarData("6/24/2011",12049.24,12057.19,11925.42,11934.58),
                    new BarData("6/27/2011",11934.66,12098.81,11934.05,12043.56),
                    new BarData("6/28/2011",12042.28,12190.43,12042.28,12188.69),
                    new BarData("6/29/2011",12187.63,12284.39,12175.86,12261.42),
                    new BarData("6/30/2011",12262.25,12427.09,12262.10,12414.34),
                    new BarData("7/1/2011",12412.07,12596.13,12404.08,12582.77),
                    new BarData("7/5/2011",12583.00,12601.80,12540.58,12569.87),
                    new BarData("7/6/2011",12562.47,12643.24,12539.21,12626.02),
                    new BarData("7/7/2011",12627.23,12753.89,12627.23,12719.49),
                    new BarData("7/8/2011",12717.90,12717.90,12567.41,12657.20),
                    new BarData("7/11/2011",12655.62,12655.84,12470.30,12505.76),
                    new BarData("7/12/2011",12505.54,12570.58,12446.88,12446.88),
                    new BarData("7/13/2011",12447.33,12611.04,12447.33,12491.61),
                    new BarData("7/14/2011",12491.53,12581.98,12414.41,12437.12),
                    new BarData("7/15/2011",12437.12,12504.82,12406.09,12479.73),
                    new BarData("7/18/2011",12475.11,12475.26,12296.23,12385.16),
                    new BarData("7/19/2011",12386.03,12607.56,12385.96,12587.42),
                    new BarData("7/20/2011",12583.68,12603.51,12546.56,12571.91),
                    new BarData("7/21/2011",12567.07,12751.43,12566.61,12724.41),
                    new BarData("7/22/2011",12724.71,12740.87,12644.19,12681.16),
                    new BarData("7/25/2011",12679.72,12679.95,12536.19,12592.80),
                    new BarData("7/26/2011",12592.12,12593.40,12489.04,12501.30),
                    new BarData("7/27/2011",12498.42,12498.65,12289.69,12302.55),
                    new BarData("7/28/2011",12301.72,12384.90,12226.83,12240.11),
                    new BarData("7/29/2011",12239.36,12243.07,12083.45,12143.24),
                    new BarData("8/1/2011",12144.22,12282.42,11998.08,12132.49),
                    new BarData("8/2/2011",12129.77,12130.30,11865.56,11866.62),
                    new BarData("8/3/2011",11863.74,11904.91,11700.34,11896.44),
                    new BarData("8/4/2011",11893.86,11893.94,11372.14,11383.68),
                    new BarData("8/5/2011",11383.98,11555.41,11139.00,11444.61),
                    new BarData("8/8/2011",11433.93,11434.09,10809.85,10809.85),
                    new BarData("8/9/2011",10810.91,11244.01,10604.07,11239.77),
                    new BarData("8/10/2011",11228.00,11228.00,10686.49,10719.94),
                    new BarData("8/11/2011",10729.85,11278.90,10729.85,11143.31),
                    new BarData("8/12/2011",11143.46,11346.67,11142.18,11269.02),
                    new BarData("8/15/2011",11269.85,11484.60,11269.85,11482.90),
                    new BarData("8/16/2011",11480.48,11488.01,11292.63,11405.93),
                    new BarData("8/17/2011",11392.01,11529.67,11322.30,11410.21),
                    new BarData("8/18/2011",11406.27,11406.50,10881.60,10990.58),
                    new BarData("8/19/2011",10989.75,11086.40,10801.41,10817.65),
                    new BarData("8/22/2011",10820.37,11020.55,10820.37,10854.65),
                    new BarData("8/23/2011",10854.58,11176.84,10854.43,11176.76),
                    new BarData("8/24/2011",11175.78,11331.57,11113.04,11320.71),
                    new BarData("8/25/2011",11321.02,11406.39,11106.76,11149.82),
                    new BarData("8/26/2011",11145.20,11326.43,10929.20,11284.54),
                    new BarData("8/29/2011",11286.65,11541.78,11286.58,11539.25),
                    new BarData("8/30/2011",11532.13,11630.07,11429.39,11559.95),
                    new BarData("8/31/2011",11560.48,11712.60,11528.08,11613.53),
                    new BarData("9/1/2011",11613.30,11716.84,11488.46,11493.57),
                    new BarData("9/2/2011",11492.06,11492.14,11211.35,11240.26),
                    new BarData("9/6/2011",11237.31,11237.46,10932.53,11139.30),
                    new BarData("9/7/2011",11137.63,11414.86,11137.63,11414.86),
                    new BarData("9/8/2011",11414.86,11477.30,11283.74,11295.81),
                    new BarData("9/9/2011",11294.60,11294.83,10935.64,10992.13),
                    new BarData("9/12/2011",10990.01,11062.03,10824.76,11061.12),
                    new BarData("9/13/2011",11054.99,11140.85,10987.18,11105.85),
                    new BarData("9/14/2011",11106.83,11386.78,10993.84,11246.73),
                    new BarData("9/15/2011",11247.72,11433.40,11247.49,11433.18),
                    new BarData("9/16/2011",11433.71,11532.47,11407.41,11509.09),
                    new BarData("9/19/2011",11506.67,11506.82,11255.25,11401.01),
                    new BarData("9/20/2011",11401.47,11550.22,11373.92,11408.66),
                    new BarData("9/21/2011",11408.58,11447.86,11117.28,11124.84),
                    new BarData("9/22/2011",11121.89,11122.12,10597.14,10733.83),
                    new BarData("9/23/2011",10732.77,10808.49,10638.73,10771.48),
                    new BarData("9/26/2011",10771.78,11057.49,10771.78,11043.86),
                    new BarData("9/27/2011",11045.23,11369.30,11045.23,11190.69),
                    new BarData("9/28/2011",11189.10,11317.08,10996.98,11010.90),
                    new BarData("9/29/2011",11012.79,11271.14,10965.45,11153.98),
                    new BarData("9/30/2011",11152.32,11152.39,10909.52,10913.38),
                    new BarData("10/3/2011",10912.10,10979.19,10653.34,10655.30),
                    new BarData("10/4/2011",10651.44,10825.44,10404.49,10808.71),
                    new BarData("10/5/2011",10800.47,10950.89,10738.10,10939.95),
                    new BarData("10/6/2011",10939.87,11132.60,10858.67,11123.33),
                    new BarData("10/7/2011",11123.41,11232.05,11051.13,11103.12),
                    new BarData("10/10/2011",11104.56,11433.33,11104.56,11433.18),
                    new BarData("10/11/2011",11432.80,11447.86,11365.67,11416.30),
                    new BarData("10/12/2011",11417.36,11625.30,11417.28,11518.85),
                    new BarData("10/13/2011",11518.09,11518.09,11377.82,11478.13),
                    new BarData("10/14/2011",11478.97,11646.83,11478.66,11644.49),
                    new BarData("10/17/2011",11643.35,11643.35,11378.35,11397.00),
                    new BarData("10/18/2011",11396.17,11652.74,11296.12,11577.05),
                    new BarData("10/19/2011",11577.54,11633.70,11469.17,11504.62),
                    new BarData("10/20/2011",11502.13,11581.25,11391.14,11541.78),
                    new BarData("10/21/2011",11543.22,11812.46,11542.84,11808.79),
                    new BarData("10/24/2011",11807.96,11940.75,11805.77,11913.62),
                    new BarData("10/25/2011",11912.63,11912.86,11682.52,11706.62),
                    new BarData("10/26/2011",11707.76,11891.21,11694.36,11869.04),
                    new BarData("10/27/2011",11872.07,12284.31,11872.07,12208.55),
                    new BarData("10/28/2011",12207.34,12251.92,12164.24,12231.11),
                    new BarData("10/31/2011",12229.22,12229.29,11954.41,11955.01),
                    new BarData("11/1/2011",11951.53,11951.76,11630.03,11657.96),
                    new BarData("11/2/2011",11658.49,11876.83,11658.49,11836.04),
                    new BarData("11/3/2011",11835.59,12065.93,11835.43,12044.47),
                    new BarData("11/4/2011",12043.41,12043.49,11850.31,11983.24),
                    new BarData("11/7/2011",11983.02,12074.44,11880.69,12068.39),
                    new BarData("11/8/2011",12055.52,12187.51,12002.17,12170.18),
                    new BarData("11/9/2011",12166.40,12166.40,11736.93,11780.94),
                    new BarData("11/10/2011",11780.03,11961.14,11779.88,11893.79),
                    new BarData("11/11/2011",11896.28,12179.72,11896.28,12153.68),
                    new BarData("11/14/2011",12153.00,12170.56,12027.03,12078.98),
                    new BarData("11/15/2011",12077.92,12165.11,12001.26,12096.16),
                    new BarData("11/16/2011",12084.74,12109.03,11890.57,11905.59)
                };
            }
        }
        public static IObservable<OHLC> OHLC
        {
            get
            {
                return DATA.ToObservable().Select(bd => {
                    var sec = Security.Lookup("DMK3");
                    var oh = new OHLC(new Tick(sec, 1, (uint)(bd.Open * 100), bd.Date));
                    oh.Add(new Tick(sec, 1, (uint)(bd.High * 100), bd.Date));
                    oh.Add(new Tick(sec, 1, (uint)(bd.Low * 100), bd.Date));
                    oh.Add(new Tick(sec, 1, (uint)(bd.Close * 100), bd.Date));
                    return oh;
                });
            }
        }

    }
}
