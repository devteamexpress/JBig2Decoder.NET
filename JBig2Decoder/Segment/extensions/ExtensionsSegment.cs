﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBig2Decoder
{
    public class ExtensionSegment : Segment {

	public ExtensionSegment(JBIG2StreamDecoder streamDecoder):base(streamDecoder) {}

	public override void readSegment()  {
		for (int i = 0; i < getSegmentHeader().getSegmentDataLength(); i++) {
			decoder.readbyte();
		}
	}
}
}
