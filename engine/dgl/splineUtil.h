//-----------------------------------------------------------------------------
// Torque Game Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

#ifndef _SPLINEUTIL_H_
#define _SPLINEUTIL_H_

#ifndef _PLATFORM_H_
#include "platform/platform.h"
#endif
#ifndef _MPOINT_H_
#include "math/mPoint.h"
#endif
#ifndef _MSPLINEPATCH_H_
#include "math/mSplinePatch.h"
#endif
#ifndef _COLOR_H_
#include "core/color.h"
#endif

/// Spline utility namespace.  This is used for generating pretty splines so you can get nice curved surfaces.
/// However, many polygons are required, so use these only when needed.
namespace SplineUtil
{
/// All the info that is needed to define a spline.  This is optional for actually drawing a spline
   /// @see drawSplineBeam
   struct SplineBeamInfo
   {
      Point3F *      camPos;
      U32            numSegments;
      F32            width;
      SplinePatch *  spline;
     /// Offset for u/v texture coordinates, useful for animating the texture on the spline
      F32            uvOffset;
     /// Stretch for texture
      F32            numTexRep;
      ColorF         color;
      bool           zeroAlphaStart;  ///< first part of first segment has 0 alpha value

      SplineBeamInfo()
      {
         dMemset( this, 0, sizeof( SplineBeamInfo ) );
         numTexRep = 1.0;
      }

   };

   /// Function for drawing the spline.
   ///
   /// Use this if you only have a SplinePatch object and want to specify all of the parameters
   ///
   /// @param camPos       This parameter is the point at which each polygon will face.
   ///
   ///                     Usually, you want all of the polygons of the spline to be facing the
   ///                     camera, so the camera pos is a good bet for this parameter.
   ///
   /// @param numSegments  The SplineUtil will cut up the spline into numSegments segments.
   ///
   ///                     More segments means more smoothness, but less framerate.
   ///
   /// @param width        The width of the spline beam.
   ///
   /// @param spline       The SplinePatch data structure for the given spline beam.
   ///
   ///                     @see SplinePatch
   ///
   /// @param uvOffset     This should be called textureOffset, since it is only
   ///                     an offset along the spline and not perpendicular.  This parameter
   ///                     can be used for "sliding" the spline texture down the spline shaft
   ///                     to make it a little more dynamic.
   ///
   /// @param numTexRep    This is the scale of the texture so you can squish or stretch it.
   void drawSplineBeam( const Point3F& camPos, U32 numSegments, F32 width,
                        SplinePatch &spline, F32 uvOffset = 0.0, F32 numTexRep = 1.0 );

   /// Function for drawing a spline.  Only needs SplineBeamInfo.
   /// @see SplineBeamInfo
   void drawSplineBeam( SplineBeamInfo &sbi );
}



#endif
