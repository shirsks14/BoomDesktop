/*
* MATLAB Compiler: 6.2 (R2016a)
* Date: Sun Apr 24 03:12:08 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:soundPlotter,PlotSound,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Sujan\Desktop\Data\SoundPlotter\for_testing" "-v"
* "class{PlotSound:C:\Users\Sujan\Desktop\Data\Circle.m,C:\Users\Sujan\Desktop\Data\dBAtDi
* stance.m,C:\Users\Sujan\Desktop\Data\dBWithDistance.m,C:\Users\Sujan\Desktop\Data\fourie
* rtransform.m,C:\Users\Sujan\Desktop\Data\maxDistance.m,C:\Users\Sujan\Desktop\Data\plotS
* ound.m,C:\Users\Sujan\Desktop\Data\soundint.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace soundPlotterNative
{

  /// <summary>
  /// The PlotSound class provides a CLS compliant, Object (native) interface to the
  /// MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\Circle.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\dBAtDistance.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\dBWithDistance.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\fouriertransform.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\maxDistance.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\plotSound.m
  /// <newpara></newpara>
  /// C:\Users\Sujan\Desktop\Data\soundint.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PlotSound : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static PlotSound()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "soundPlotter.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the PlotSound class.
    /// </summary>
    public PlotSound()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PlotSound()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Circle()
    {
      return mcr.EvaluateFunction("Circle", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="radius">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Circle(Object radius)
    {
      return mcr.EvaluateFunction("Circle", radius);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Circle(Object radius, Object center)
    {
      return mcr.EvaluateFunction("Circle", radius, center);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <param name="pathangle">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object Circle(Object radius, Object center, Object pathangle)
    {
      return mcr.EvaluateFunction("Circle", radius, center, pathangle);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Circle(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="radius">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Circle(int numArgsOut, Object radius)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", radius);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Circle(int numArgsOut, Object radius, Object center)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", radius, center);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the Circle MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="radius">Input argument #1</param>
    /// <param name="center">Input argument #2</param>
    /// <param name="pathangle">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] Circle(int numArgsOut, Object radius, Object center, Object pathangle)
    {
      return mcr.EvaluateFunction(numArgsOut, "Circle", radius, center, pathangle);
    }


    /// <summary>
    /// Provides an interface for the Circle function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// th = linspace( pathangle + pi/4, pathangle -pi/4, 100);
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("Circle", 3, 1, 0)]
    protected void Circle(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("Circle", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dBAtDistance()
    {
      return mcr.EvaluateFunction("dBAtDistance", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dBAtDistance(Object fileName)
    {
      return mcr.EvaluateFunction("dBAtDistance", fileName);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="distance">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dBAtDistance(Object fileName, Object distance)
    {
      return mcr.EvaluateFunction("dBAtDistance", fileName, distance);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dBAtDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBAtDistance", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dBAtDistance(int numArgsOut, Object fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBAtDistance", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the dBAtDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="distance">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dBAtDistance(int numArgsOut, Object fileName, Object distance)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBAtDistance", fileName, distance);
    }


    /// <summary>
    /// Provides an interface for the dBAtDistance function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("dBAtDistance", 2, 1, 0)]
    protected void dBAtDistance(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("dBAtDistance", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dBWithDistance()
    {
      return mcr.EvaluateFunction("dBWithDistance", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object dBWithDistance(Object filename)
    {
      return mcr.EvaluateFunction("dBWithDistance", filename);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dBWithDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBWithDistance", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the dBWithDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="filename">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] dBWithDistance(int numArgsOut, Object filename)
    {
      return mcr.EvaluateFunction(numArgsOut, "dBWithDistance", filename);
    }


    /// <summary>
    /// Provides an interface for the dBWithDistance function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 20*log10(P)
    /// 20*log10(soundint(400,const,r_o))
    /// Y=0;
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("dBWithDistance", 1, 3, 0)]
    protected void dBWithDistance(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("dBWithDistance", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fouriertransform()
    {
      return mcr.EvaluateFunction("fouriertransform", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fouriertransform(Object fileName)
    {
      return mcr.EvaluateFunction("fouriertransform", fileName);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="plotCheck">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object fouriertransform(Object fileName, Object plotCheck)
    {
      return mcr.EvaluateFunction("fouriertransform", fileName, plotCheck);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fouriertransform(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "fouriertransform", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fouriertransform(int numArgsOut, Object fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "fouriertransform", fileName);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the fouriertransform MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <param name="plotCheck">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] fouriertransform(int numArgsOut, Object fileName, Object plotCheck)
    {
      return mcr.EvaluateFunction(numArgsOut, "fouriertransform", fileName, plotCheck);
    }


    /// <summary>
    /// Provides an interface for the fouriertransform function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Sound Analysis with MATLAB Implementation      
    /// Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14   
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("fouriertransform", 2, 2, 0)]
    protected void fouriertransform(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("fouriertransform", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object maxDistance()
    {
      return mcr.EvaluateFunction("maxDistance", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object maxDistance(Object p)
    {
      return mcr.EvaluateFunction("maxDistance", p);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] maxDistance(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "maxDistance", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the maxDistance MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="p">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] maxDistance(int numArgsOut, Object p)
    {
      return mcr.EvaluateFunction(numArgsOut, "maxDistance", p);
    }


    /// <summary>
    /// Provides an interface for the maxDistance function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("maxDistance", 1, 3, 0)]
    protected void maxDistance(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("maxDistance", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the plotSound MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object plotSound()
    {
      return mcr.EvaluateFunction("plotSound", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the plotSound MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object plotSound(Object fileName)
    {
      return mcr.EvaluateFunction("plotSound", fileName);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the plotSound MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] plotSound(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotSound", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the plotSound MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="fileName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] plotSound(int numArgsOut, Object fileName)
    {
      return mcr.EvaluateFunction(numArgsOut, "plotSound", fileName);
    }


    /// <summary>
    /// Provides an interface for the plotSound function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
    /// color = ['g'; 'b'; 'y';'m';'r'];
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("plotSound", 1, 2, 0)]
    protected void plotSound(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("plotSound", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }
    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object soundint()
    {
      return mcr.EvaluateFunction("soundint", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="distance">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object soundint(Object distance)
    {
      return mcr.EvaluateFunction("soundint", distance);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object soundint(Object distance, Object const0)
    {
      return mcr.EvaluateFunction("soundint", distance, const0);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the soundint MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <param name="r_o">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object soundint(Object distance, Object const0, Object r_o)
    {
      return mcr.EvaluateFunction("soundint", distance, const0, r_o);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] soundint(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="distance">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] soundint(int numArgsOut, Object distance)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", distance);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] soundint(int numArgsOut, Object distance, Object const0)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", distance, const0);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the soundint MATLAB function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="distance">Input argument #1</param>
    /// <param name="const0">Input argument #2</param>
    /// <param name="r_o">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] soundint(int numArgsOut, Object distance, Object const0, Object r_o)
    {
      return mcr.EvaluateFunction(numArgsOut, "soundint", distance, const0, r_o);
    }


    /// <summary>
    /// Provides an interface for the soundint function in which the input and output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("soundint", 3, 1, 0)]
    protected void soundint(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("soundint", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
