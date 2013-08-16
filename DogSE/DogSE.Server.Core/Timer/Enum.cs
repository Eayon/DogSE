#region zh-CHS 2010 - 2010 DemoSoft �Ŷ� | en 2010-2010 DemoSoft Team

//     NOTES
// ---------------
//
// This file is a part of the MMOCE(Massively Multiplayer Online Client Engine) for .NET.
//
//                              2006-2010 DemoSoft Team
//
//
// First Version : by H.Q.Cai - mailto:caihuanqing@hotmail.com

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU Lesser General Public License as published
 *   by the Free Software Foundation; either version 2.1 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/

#region zh-CHS �������ֿռ� | en Include namespace

#endregion

namespace DogSE.Server.Core.Timer
{
    #region zh-CHS ö�� | en Enum
    /// <summary>
    /// ʱ��Ƭ���ȼ���ö�ٶ���
    /// </summary>
    public enum TimerFrequency
    {
        /// <summary>
        /// ʵʱ��ʱ��Ƭ
        /// </summary>
        EveryTick = 0x00,
        /// <summary>
        /// 25�����ʱ��Ƭ
        /// </summary>
        TwentyFiveMS = 0x01,
        /// <summary>
        /// 100�����ʱ��Ƭ
        /// </summary>
        HundredMS = 0x02,
        /// <summary>
        /// 500�����ʱ��Ƭ
        /// </summary>
        FiveHundredMS = 0x03,
        /// <summary>
        /// 1���ʱ��Ƭ
        /// </summary>
        OneSecond = 0x04,
        /// <summary>
        /// 5���ʱ��Ƭ
        /// </summary>
        FiveSeconds = 0x05,
        /// <summary>
        /// 20���ʱ��Ƭ
        /// </summary>
        TwentySeconds = 0x06,
        /// <summary>
        /// 1���ӵ�ʱ��Ƭ
        /// </summary>
        OneMinute = 0x07
    }

    /// <summary>
    /// ָ�� TimeSlice �ĵ������ȼ���
    /// </summary>
    public enum TimerPriority
    {
        /// <summary>
        /// ���Խ� TimeSlice �����ھ����κ��������ȼ����߳�֮��
        /// </summary>
        Lowest = 0,
        /// <summary>
        /// ���Խ� TimeSlice �����ھ��� AboveNormal ���ȼ����߳�֮���ھ��� BelowNormal ���ȼ����߳�֮ǰ��Ĭ������£��߳̾��� Normal ���ȼ���
        /// </summary>
        Normal = 2,
        /// <summary>
        /// ���Խ� TimeSlice �����ھ����κ��������ȼ����߳�֮ǰ��
        /// </summary>
        Highest = 4,
    }
    #endregion
}
#endregion