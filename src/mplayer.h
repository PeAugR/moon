/*
 * mplayer.h: 
 *
 * Author: Jeffrey Stedfast <fejj@novell.com>
 *
 * Copyright 2007 Novell, Inc. (http://www.novell.com)
 *
 * See the LICENSE file included with the distribution for details.
 */

#ifndef __MPLAYER_H__

#include <glib.h>
#include <cairo.h>
#include <stdint.h>

struct AVFormatContext;
struct Audio;
struct Video;

class MediaPlayer {
public:
	char *uri;
	
	GStaticMutex pause_mutex;
	bool paused;
	
	bool stop;
	
	AVFormatContext *av_ctx;
	
	GThread *audio_thread;
	GThread *io_thread;
	
	Audio *audio;
	Video *video;
	
	// sync
	uint64_t pause_time;
	uint64_t start_time;  
	
	uint64_t target_pts;
	
	// read-only
	int width, height;
	bool opened;
	
	MediaPlayer ();
	~MediaPlayer ();
	
	bool AdvanceFrame ();
	void Render (cairo_t *cr);
	
	bool Open ();
	bool Open (const char *uri);
	void Close ();
	
	bool IsPlaying ();
	guint Play (GSourceFunc callback, void *user_data);
	void Pause ();
	void Stop ();
	
	bool CanSeek ();
	void Seek (double position);
	double Position ();
	
	void Mute ();
	void UnMute ();
	bool IsMuted ();
	
	double GetVolume ();
	void SetVolume (double volume);
};

#endif /* __MPLAYER_H__ */
