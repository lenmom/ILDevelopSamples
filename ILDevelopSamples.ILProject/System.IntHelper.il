.assembly extern mscorlib {}

.assembly ILDevelopSamples.ILProject
{
  .ver 1:0:0:0
}

.module ILDevelopSamples.ILProject.dll

.class public abstract auto ansi sealed beforefieldinit System.IntHelper
{
  .method public hidebysig static int32 Square(int32 a) cil managed aggressiveinlining
  {
    .maxstack 2
    ldarg.0
    dup
    mul
    ret
  }
}