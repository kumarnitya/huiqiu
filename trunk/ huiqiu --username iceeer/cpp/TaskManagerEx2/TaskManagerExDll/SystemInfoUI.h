//////////////////////////////////////////////////////////////
// File:		// SystemInfoUI.h
// File time:	// 31.03.2005	22:26
// Version: 	// 1.0
// Author:		// Sergey Kolomenkin <register@tut.by>
// Copyright:	// (c) Sergey Kolomenkin, Minsk, 2005
// Description: //////////////////////////////////////////////
//   Some useful routines...
//   

#ifndef _SYSTEMINFOUI_H_UID0000002785942569
#define _SYSTEMINFOUI_H_UID0000002785942569

///////////////////////////////////////////////////////////////////////////////////////////////////

#include "SystemInfo.h"

#include "Resource.h"
#include "Localization.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

#define COLUMN_PID					LocLoadString(IDS_COLUMN_PID)
#define COLUMN_PROCESS_NAME			LocLoadString(IDS_COLUMN_PROCESS_NAME)
#define COLUMN_HANDLE				LocLoadString(IDS_COLUMN_HANDLE)
#define COLUMN_HANDLE_PID			LocLoadString(IDS_COLUMN_HANDLE_PID)

#define COLUMN_MODULE_BASE			LocLoadString(IDS_COLUMN_MODULE_BASE)
#define COLUMN_MODULE_LENGTH		LocLoadString(IDS_COLUMN_MODULE_LENGTH)
#define COLUMN_MODULE_USAGE			LocLoadString(IDS_COLUMN_MODULE_USAGE)
#define COLUMN_MODULE_NAME			LocLoadString(IDS_COLUMN_MODULE_NAME)
#define COLUMN_MODULE_FILE_SIZE		LocLoadString(IDS_COLUMN_MODULE_FILE_SIZE)
#define COLUMN_MODULE_VERSION		LocLoadString(IDS_COLUMN_MODULE_VERSION)
#define COLUMN_MODULE_PATH			LocLoadString(IDS_COLUMN_MODULE_PATH)

#define COLUMN_DRIVER_NAME			LocLoadString(IDS_COLUMN_DRIVER_NAME)
#define COLUMN_DRIVER_ADDRESS		LocLoadString(IDS_COLUMN_DRIVER_ADDRESS)
#define COLUMN_DRIVER_TYPE			LocLoadString(IDS_COLUMN_DRIVER_TYPE)
#define COLUMN_DRIVER_PATH			LocLoadString(IDS_COLUMN_DRIVER_PATH)
#define COLUMN_DRIVER_FILE_SIZE		LocLoadString(IDS_COLUMN_DRIVER_FILE_SIZE)
#define COLUMN_DRIVER_FULL_NAME		LocLoadString(IDS_COLUMN_DRIVER_FULL_NAME)


#define COLUMN_MEMORY_ADDRESS		LocLoadString(IDS_COLUMN_MEMORY_ADDRESS)
#define COLUMN_MEMORY_SIZE			LocLoadString(IDS_COLUMN_MEMORY_SIZE)
#define COLUMN_MEMORY_TYPE			LocLoadString(IDS_COLUMN_MEMORY_TYPE)
#define COLUMN_MEMORY_BLOCKS		LocLoadString(IDS_COLUMN_MEMORY_BLOCKS)
#define COLUMN_MEMORY_PROTECT		LocLoadString(IDS_COLUMN_MEMORY_PROTECT)
#define COLUMN_MEMORY_DESCRIPTION	LocLoadString(IDS_COLUMN_MEMORY_DESCRIPTION)

#define COLUMN_MEMORY_TYPE_UNKNOWN	LocLoadString(IDS_COLUMN_MEMORY_TYPE_UNKNOWN)
#define COLUMN_MEMORY_TYPE_FREE		LocLoadString(IDS_COLUMN_MEMORY_TYPE_FREE)
#define COLUMN_MEMORY_TYPE_RESERVE	LocLoadString(IDS_COLUMN_MEMORY_TYPE_RESERVE)
#define COLUMN_MEMORY_TYPE_IMAGE	LocLoadString(IDS_COLUMN_MEMORY_TYPE_IMAGE)
#define COLUMN_MEMORY_TYPE_MAPPED	LocLoadString(IDS_COLUMN_MEMORY_TYPE_MAPPED)
#define COLUMN_MEMORY_TYPE_PRIVATE	LocLoadString(IDS_COLUMN_MEMORY_TYPE_PRIVATE)

#define COLUMN_THREAD_TID			LocLoadString(IDS_COLUMN_THREAD_TID)
#define COLUMN_THREAD_PRIORITY		LocLoadString(IDS_COLUMN_THREAD_PRIORITY)
#define COLUMN_THREAD_START_ADDRESS	LocLoadString(IDS_COLUMN_THREAD_START_ADDRESS)
#define COLUMN_THREAD_MODULE		LocLoadString(IDS_COLUMN_THREAD_MODULE)
#define COLUMN_THREAD_STATE			LocLoadString(IDS_COLUMN_THREAD_STATE)
#define COLUMN_THREAD_WAIT_REASON	LocLoadString(IDS_COLUMN_THREAD_REASON)
#define COLUMN_THREAD_CONTEXT_SWITCHES	LocLoadString(IDS_COLUMN_THREAD_CONTEXT_SWITCHES)
#define COLUMN_THREAD_WAIT_TIME		LocLoadString(IDS_COLUMN_THREAD_WAIT_TIME)

#define COLUMN_HANDLE_ACCESS		LocLoadString(IDS_COLUMN_HANDLE_ACCESS)
#define COLUMN_HANDLE_TYPE			LocLoadString(IDS_COLUMN_HANDLE_TYPE)
#define COLUMN_HANDLE_TYPE_NUMBER	LocLoadString(IDS_COLUMN_HANDLE_TYPE_NUMBER)
#define COLUMN_HANDLE_NAME			LocLoadString(IDS_COLUMN_HANDLE_NAME)

#define COLUMN_FILE_NAME			LocLoadString(IDS_COLUMN_FILE_NAME)
#define COLUMN_FILE_PATH			LocLoadString(IDS_COLUMN_FILE_PATH)
#define COLUMN_FILE_DEVICE			LocLoadString(IDS_COLUMN_FILE_DEVICE)

#define COLUMN_WINDOW_CAPTION		LocLoadString(IDS_COLUMN_WINDOW_CAPTION)
#define COLUMN_WINDOW_CLASS			LocLoadString(IDS_COLUMN_WINDOW_CLASS)
#define COLUMN_WINDOW_RECT			LocLoadString(IDS_COLUMN_WINDOW_RECT)
#define COLUMN_WINDOW_STYLE			LocLoadString(IDS_COLUMN_WINDOW_STYLE)
#define COLUMN_WINDOW_EX_STYLE		LocLoadString(IDS_COLUMN_WINDOW_EX_STYLE)

///////////////////////////////////////////////////////////////////////////////////////////////////

#endif //ifndef _SYSTEMINFOUI_H_UID0000002785942569
